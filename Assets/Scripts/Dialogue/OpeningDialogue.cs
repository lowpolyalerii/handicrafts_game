using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;
using UnityEngine.UI;
using System;


public class OpeningDialogue : MonoBehaviour
{
    [Header("Params")]
    public float textSpeed;

    [Header("Buttons")]
    public Button[] choiceButtons;

    [Header("InkFile")]
    public TextAsset inkFile;

    [Header("CanvasElements")]
    public TextMeshProUGUI textBox;
    public GameObject canvas;

    private int index;

    private Story story;
    private Coroutine displayLineCoroutine;

    void Start()
    {
        story = new Story(inkFile.text);
    }

    private void Update()
    {
        if ((Input.GetKeyUp(KeyCode.E)))
        {
            ContinueStory();
        }
    }

    public void ContinueStory()
    {
        if ((Input.GetKeyUp(KeyCode.E)))
        {
            if (story.canContinue)
            {
                if (displayLineCoroutine != null)
                {
                    StopCoroutine(displayLineCoroutine);
                }
            canvas.gameObject.SetActive(true);
            textBox.gameObject.SetActive(true);

            displayLineCoroutine = StartCoroutine(DisplayLine(story.Continue())); //old one textBox.text = story.Continue();
            
            ShowChoices();
            }
        else
        {
            FinishDialogue();
        }

        }
    }

    private IEnumerator DisplayLine(string line)
    {
        textBox.text = "";

        foreach (char c in line.ToCharArray())
        {
            textBox.text += c;
            yield return new WaitForSeconds(textSpeed);
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
            index++;
        }
        for(int i = index; i < 2; i++)
        {
            choiceButtons[i].gameObject.SetActive(false);
        }
    }

    public void SetDecision(int choiceIndex)
    {
        story.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
    }

    private void FinishDialogue()
    {
        StopAllCoroutines();
        textBox.gameObject.SetActive(false);
        canvas.gameObject.SetActive(false);
        for (int i = 0; i < choiceButtons.Length; i++)
        {
            choiceButtons[i].gameObject.SetActive(false);
        }
    }
}
