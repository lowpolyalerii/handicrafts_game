using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorldDialogue3 : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    [SerializeField] private CameraEdgePan cameraEdgePan;
    private int index;
    public GameObject canvas;
    public Collectable collected;
    public bool collectedall = false;
    public GameObject SecretPaper1;
    public GameObject discard2;
    public GameObject interactbutton2;

    void Start()
    {
        textComponent.text = string.Empty;
        canvas.gameObject.SetActive(false);
        SecretPaper1.gameObject.SetActive(false);
        discard2.gameObject.SetActive(false);
        interactbutton2.gameObject.SetActive(false);
    }

    void Update()
    {
        if (collected.collector.ScissorsFound == true & collected.collector.PaperFound == true & collected.collector.PenFound == true & collected.collector.HairtieFound == true & collected.collector.PlushieFound == true)
        {
            if (collectedall == false)
            {
                collectedall = true;
                StartDialogue();
                Debug.Log("Collected all");
            }
        }

        if (collectedall == true)
        {
            gameObject.SetActive(true);
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
            canvas.gameObject.SetActive(false);
            SecretPaper1.gameObject.SetActive(true);
            discard2.gameObject.SetActive(true);
            interactbutton2.gameObject.SetActive(true);
        }
    }
}
