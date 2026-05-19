using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


public class DialogueManager : MonoBehaviour
{
    public TextAsset inkFile;
    public TextMeshProUGUI textBox;
    public TextMeshProUGUI Name;
    public GameObject canvas;
    public NPCTalk npcTalk;
    public Button[] choiceButtons;
    [SerializeField] private GameObject settingsicon;
    [SerializeField] private TextMeshProUGUI HTPText;
    private int index;
    public float textSpeed;
    [SerializeField] private CameraEdgePan cameraEdgePan;
    public bool trigger;
    public bool convotrigger = false;
    string savedJson = "hello";
    [SerializeField] bool inconvo;

    public bool externalcalled = false;

    int counter = 0;
    [SerializeField] int lineNum;

    private const string PORTRAIT_TAG = "portrait";
    private const string HAIR_TAG = "hair";

    [SerializeField] private Animator portraitAnimator;
    [SerializeField] private Animator hairAnimator;

    //string M_DefaultIdle = "#portrait:M_Default";
    //string M_HairCrownIdle = "#portrait:M_HairCrownDefault";
    //string M_HairUpIdle = "#portrait:M_HairUpDefault";


    private Story story;


    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkFile.text);
        savedJson = story.state.ToJson();
        inconvo = false;

        story.BindExternalFunction("changeScene", (string sceneName) =>
        {
            SceneManager.LoadScene("PaintingPicture");
            externalcalled = true;
        });
    }

    private void Update()
    {
        if ((Input.GetKeyUp(KeyCode.E)) && npcTalk.trigger == true && convotrigger == false && inconvo == false)
        {
            inconvo = true;
            ContinueStory();
            Debug.Log(counter);
        }

        else if ((Input.GetKeyUp(KeyCode.E)) && convotrigger == false && inconvo == true)
        {
            ContinueStory();
            Debug.Log(counter);
        }

        //else if
        //((Input.GetKeyUp(KeyCode.E))
    }


    // Update is called once per frame
    public void ContinueStory()
    {
        if (story.canContinue)
        {

            if (counter == lineNum) 
            {
                savedJson = story.state.ToJson();
            }
            counter++;

            //Debug.Log(savedJson);
            //trigger = true;
            cameraEdgePan.enabled = false;
            canvas.gameObject.SetActive(true);
            textBox.gameObject.SetActive(true);
            textBox.text = story.Continue();
            settingsicon.gameObject.SetActive(false);
            HTPText.enabled = false;
            ShowChoices();

            // handle tags
            HandleTags(story.currentTags);
        }
        else
        {
            FinishDialogue();
            inconvo = false;
            story.state.LoadJson(savedJson);
            counter = lineNum;

            story.BindExternalFunction("changeScene", (string sceneName) =>
            {
                SceneManager.LoadScene("PaintingPicture");
                externalcalled = true;
                FinishDialogue();
            });
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

                case HAIR_TAG:
                    hairAnimator.Play(tagValue);
                    break;

                default:
                    Debug.LogWarning("Tag came in but is not currently being handled: " + tag);
                    break;
            }
        }

       /* story.BindExternalFunction("LoadScene", (string PaintingPicture) => {
            SceneManager.LoadScene("PaintingPicture");
        });*/
    }

    private void ShowChoices()
    {
        List<Choice> choices = story.currentChoices;
        int index = 0;
        foreach (Choice c in choices)
        {
            choiceButtons[index].GetComponentInChildren<TextMeshProUGUI>().text = c.text;
            choiceButtons[index].gameObject.SetActive(true);
            index++;

            trigger = false;
            convotrigger = true;
        }
        for(int i = index; i < 3; i++)
        {
            choiceButtons[i].gameObject.SetActive(false);
            trigger = true;
            //storytrigger = false;
        }
    }

    public void SetDecision(int choiceIndex)
    {
        story.ChooseChoiceIndex(choiceIndex);
        convotrigger = false;
        ContinueStory();
    }

    private void FinishDialogue()
    {
        cameraEdgePan.enabled = true;
        //trigger = false;
        //StopAllCoroutines();

        //////unbinding function
        story.UnbindExternalFunction("changeScene");
        Debug.Log("Ended");

        textBox.gameObject.SetActive(false);
        canvas.gameObject.SetActive(false);
        settingsicon.gameObject.SetActive(true);
        HTPText.enabled = true;

        for (int i = 0; i < choiceButtons.Length; i++)
            {
                choiceButtons[i].gameObject.SetActive(false);
            }

        convotrigger = false;
    }
}
