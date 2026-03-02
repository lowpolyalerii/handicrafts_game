using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorldDialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public NPCTalk npcTalk;
    public GameObject canvas;
    public float textSpeed;
    private int index;


    void Start()
    {
        canvas.gameObject.SetActive(false);
        textComponent.text = string.Empty;
    }

    void Update()
    {
        if ((Input.GetKeyUp(KeyCode.E)) && npcTalk.trigger == true)
        {
            canvas.SetActive(true);
            StartDialogue();

            if (textComponent.text == lines[index])
            {
                textComponent.text = string.Empty;
                NextLine();
                // e appear when sentence finished
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