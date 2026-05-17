using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;


public class CutsceneDialogue : MonoBehaviour
{
    public TextAsset inkFile;
    public TextMeshProUGUI textBox;
    public GameObject canvas;
    public Button[] choiceButtons;
    private int index;
    [SerializeField] private float typingSpeed = 0.04f;
    public bool trigger;

    private Coroutine displayLineCoroutine;

    [SerializeField] private GameObject continueIcon;

    public bool externalcalled = false;

    private const string PORTRAIT_TAG = "portrait";
    private const string VIGNETTE_TAG = "vignette";

    [SerializeField] private Animator portraitAnimator;
    [SerializeField] private Animator vignetteAnimator;


    private Story story;

    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkFile.text);
        trigger = true;
        ContinueStory();
    }

    private void Update()
    {
        if ((Input.GetKeyUp(KeyCode.E)) && trigger == true)
        {
            ContinueStory();
        }
    }

    public void EnterDialogueMode()
    {
        if (externalcalled == false)
        {
            story.BindExternalFunction("changeScene", (string sceneName) =>
            {
                Debug.Log(sceneName);
                externalcalled = true;
            });
        }

        if (externalcalled == true)
        {
            return;
        }
    }

    // Update is called once per frame
    public void ContinueStory()
    {
        //////binding function
        //EnterDialogueMode();

        if (story.canContinue)
        {
            canvas.SetActive(true);
            textBox.gameObject.SetActive(true);

            if (displayLineCoroutine != null) 
            {
                StopCoroutine(displayLineCoroutine);
            }

            displayLineCoroutine = StartCoroutine(DisplayLine(story.Continue()));
            ShowChoices();

            // handle tags
            HandleTags(story.currentTags);
        }
        else
        {
            FinishDialogue();
        }
    }

    private IEnumerator DisplayLine(string line)
    {
        bool isAddingRichTextTag = false;

        //set the text to the full line, but set the visible characters to 0
        textBox.text = line;
        textBox.maxVisibleCharacters = 0;

        //hide items while text is typing
        continueIcon.SetActive(false);

        //display each letter one at a time
        foreach(char letter in line.ToCharArray())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                textBox.maxVisibleCharacters = line.Length;
                break;
            }

            //check for rich text tag
            if (letter == '<' || isAddingRichTextTag)
            {
                isAddingRichTextTag = true;
                if (letter == '>')
                {
                    isAddingRichTextTag = false;
                }
            }

            else
            {
                textBox.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }

            textBox.maxVisibleCharacters++;
            yield return new WaitForSeconds(typingSpeed);
        }

        if (story.currentChoices.Count > 0)
        {
            continueIcon.SetActive(false);
        }
        else
        {
            continueIcon.SetActive(true);
        }
    }

    private void HandleTags(List<string> currentTags)
    {
        foreach (string tag in currentTags)
        {
            string[] splitTag = tag.Split(":");
            if (splitTag.Length != 2)
            {
                Debug.LogError("Tag could not be appropriately parsed: " + tag);
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            switch (tagKey)
            {
                case PORTRAIT_TAG:
                    portraitAnimator.Play(tagValue);
                    break;

                case VIGNETTE_TAG:
                    vignetteAnimator.Play(tagValue);
                    break;

                default:
                    Debug.LogWarning("Tag came in but is not currently being handled: " + tag);
                    break;
            }
        }
    }

    private void ShowChoices()
    {
        List<Choice> choices = story.currentChoices;
        int index = 0;
        foreach (Choice c in choices)
        {
            choiceButtons[index].GetComponentInChildren<TextMeshProUGUI>().text = c.text;
            choiceButtons[index].gameObject.SetActive(true);

            trigger = false;

            index++;
        }
        for (int i = index; i < 2; i++)
        {
            choiceButtons[i].gameObject.SetActive(false);
            trigger = true;
        }
        textBox.gameObject.SetActive(true);
    }

    public void SetDecision(int choiceIndex)
    {
        story.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
    }

    public void FinishDialogue()
    {
        //trigger = false;
        //StopAllCoroutines();

        //////unbinding function
        //story.UnbindExternalFunction("changeScene");
        //Debug.Log("Ended");

        textBox.gameObject.SetActive(false);
        canvas.SetActive(false);

        for (int i = 0; i < choiceButtons.Length; i++)
        {
            choiceButtons[i].gameObject.SetActive(false);
        }
    }
}
