using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorldDialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;
    public ObjectCollector OBJ;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (OBJ.collected == 1)
        {
            StartDialogue();
            canvas.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (textComponent.text == lines[index])
                {
                    NextLine();
                }
                else
                {
                    StopAllCoroutines();
                    textComponent.text = lines[index];
                }
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
            gameObject.SetActive(false);
        }
    }
}

//    public ObjectCollector OBJ;
/*
{
    if (OBJ.collected == 1)
    {
        canvas.SetActive(true);
        StartDialogue();

        if (Input.GetKeyDown(KeyCode.E))
        {

            */