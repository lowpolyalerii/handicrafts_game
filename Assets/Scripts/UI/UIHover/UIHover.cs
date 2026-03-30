using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class UIHover : MonoBehaviour {

    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private NPCTalk npcInteract;

    private void Update()
    {

        if (npcInteract.trigger)
        {
            Show();
        } else
        {
            Hide();
        }
    }

    public void Show()
    {
        containerGameObject.SetActive(true);
    }

    public void Hide()
    {
        containerGameObject.SetActive(false);
    }
}
