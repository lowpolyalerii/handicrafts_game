using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitch : MonoBehaviour
{
    public GameObject DialogueBox;

    public void Update()
    {
        if (DialogueBox.activeSelf == false)
        {
            //Invoke("LoadSceneDelay", 3);
            SceneManager.LoadScene("MainWorld");
        }
    }
}
