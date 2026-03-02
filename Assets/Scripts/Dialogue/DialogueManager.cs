using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;


public class DialogueManager : MonoBehaviour
{
    public TextAsset inkFile;
    public TextMeshProUGUI textBox;
    public TextMeshProUGUI Name;
    public GameObject canvas;
    public NPCTalk npcTalk;

    private Story story;


    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkFile.text);
    }

    private void Update()
    {
        if (npcTalk)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                ContinueStory();
            }

        }
    }
    // Update is called once per frame
    void ContinueStory()
    {
        if (story.canContinue)
        {
            canvas.gameObject.SetActive(true);
            textBox.gameObject.SetActive(true);
            textBox.text = story.Continue();
        }

        else
        {
            FinishDialogue();
        }
    }

    private void FinishDialogue()
    {
        textBox.gameObject.SetActive (false);
        canvas.gameObject.SetActive(false);
    }

}
