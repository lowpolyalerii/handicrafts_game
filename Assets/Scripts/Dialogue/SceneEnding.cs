using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneEnding : MonoBehaviour
{
    public void TriggerEnding()
    {
        SceneManager.LoadScene("Ending");
    }
}
