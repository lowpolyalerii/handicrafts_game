using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorldDialogue2 : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    [SerializeField] private CameraEdgePan cameraEdgePan;
    private int index;
    public GameObject canvas;
    public Collectable collected;
    public bool collectedall = false;

    void Start()
    {
        textComponent.text = string.Empty;
        canvas.gameObject.SetActive(false);
    }

    void Update()
    {
        if (collected.collector.ScissorsFound == true && collected.collector.PaperFound == true && collected.collector.PenFound == true && collected.collector.HairtieFound == true && collected.collector.PlushieFound == true)
        {
            if (collectedall == false)
            {
                collectedall = true;
                StartDialogue();
                Debug.Log("Collected");
            }
        }

        if (collectedall == true)
        {
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
        cameraEdgePan.enabled = false;
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
            cameraEdgePan.enabled = true;
            gameObject.SetActive(false);
        }
    }
}