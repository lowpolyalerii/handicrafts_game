using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class DiaryTrigger : MonoBehaviour
{
    public GameObject DiaryEntry;

    public void WhenButtonClicked()
    {
        if(DiaryEntry.activeInHierarchy == true)
            DiaryEntry.SetActive(false);
        else
            DiaryEntry.SetActive(true);
    }

}
