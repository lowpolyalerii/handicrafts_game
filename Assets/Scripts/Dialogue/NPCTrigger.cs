using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTrigger : MonoBehaviour
{
    public NPCTalk npcTalk;

    public void Update()
    {
        if (npcTalk.trigger == true)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                Debug.Log("Dialogue works!");
            }
        }
    }


}
