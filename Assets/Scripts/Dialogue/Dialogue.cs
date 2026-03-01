using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public bool canChat = true;
    public GameObject canvas;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public NPCTalk npcTalk;

    private int index;


    void Start()
    {
        textComponent.text = string.Empty;
        canvas.SetActive(false);
    }


    void Update()
    {
        if (npcTalk)
        {
            if (Input.GetKey(KeyCode.E))
            {
                canChat = false;
                canvas.SetActive(true);
                StartDialogue();
            }
        }

        if (Input.GetKey(KeyCode.E))
        {
            if (textComponent.text == lines[index])
            {
                textComponent.text = string.Empty;
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            canvas.SetActive(false);
        }
    }
}


//Remove the dialogue script component from the dialogue box (that you followed doing the tutorial)
//and apply this script component (the script above) to your NPC.
//Create a SphearColider and place it in front of your NPC and set this as a trigger.
//Apply the canvas gameobject, the TMPro text field gameobject into the the new variable
//gameobjects field on your NPC.