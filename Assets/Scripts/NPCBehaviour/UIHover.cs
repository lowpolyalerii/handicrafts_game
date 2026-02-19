using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIHover : MonoBehaviour {

    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private NPCTalk npcTalk;

    // doesn't work rn
    private void Update()
    {
        /* this doesnt work yet
        if (NPCTalk() != null)
        {
            Show();
        } else
        {
            Hide();
        }
        */
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
