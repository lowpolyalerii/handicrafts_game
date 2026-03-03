using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;
using UnityEngine.UI;
using System;


public class DialogueManager : MonoBehaviour
{
    public TextAsset inkFile;
    public TextMeshProUGUI textBox;
    public TextMeshProUGUI Name;
    public GameObject canvas;
    public NPCTalk npcTalk;
    public Button[] choiceButtons;
    private int index;
    public float textSpeed;
    [SerializeField] public CameraEdgePan cameraEdgePan;
    public bool trigger;

    private Story story;


    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkFile.text);
    }

    private void Update()
    {
        if ((Input.GetKeyUp(KeyCode.E)) && npcTalk.trigger == true)
            {
                ContinueStory();
            }

    }


    // Update is called once per frame
    public void ContinueStory()
    {
        if (story.canContinue)
        {
            trigger = true;
            cameraEdgePan.enabled = false;
            canvas.SetActive(true);
            textBox.gameObject.SetActive(true);
            textBox.text = story.Continue();
            ShowChoices();
        }
        else
        {
            FinishDialogue();
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
        cameraEdgePan.enabled = true;
        trigger = false;
        StopAllCoroutines();
            textBox.gameObject.SetActive(false);
            canvas.SetActive(false);
            for (int i = 0; i < choiceButtons.Length; i++)
            {
                choiceButtons[i].gameObject.SetActive(false);
            }
        }
}
