using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScene : MonoBehaviour
{
    public WorldDialogue2 Foundall;
    public GameObject InteractButton;
    [SerializeField] private GameObject DispelButton;

    void Update()
    {
        if (Foundall.collectedall == true)
        {
            DispelButton.gameObject.SetActive(true);
        }
    }
}
