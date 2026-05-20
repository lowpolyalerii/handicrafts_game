using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispelObjects : MonoBehaviour
{
    [SerializeField] private GameObject CrumpledObject;
    [SerializeField] private GameObject FindDialogue;
    [SerializeField] private GameObject DispelButton;

    private void Start()
    {
        FindDialogue.gameObject.SetActive(false);
        DispelButton.gameObject.SetActive(false);
    }
    public void DispelOBJ()
    {
        Destroy(CrumpledObject);
        FindDialogue.gameObject.SetActive(true);
        DispelButton.gameObject.SetActive(false);
    }

}
