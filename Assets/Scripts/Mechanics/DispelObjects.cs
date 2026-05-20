using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispelObjects : MonoBehaviour
{
    [SerializeField] private GameObject CrumpledObject;
    [SerializeField] private GameObject CrumpledObject2;
    [SerializeField] private GameObject CrumpledObject3;

    [SerializeField] private GameObject FindDialogue;
    [SerializeField] private GameObject FindDialogue2;
    [SerializeField] private GameObject FindDialogue3;


    [SerializeField] private GameObject DispelButton;
    [SerializeField] private GameObject DispelButton2;
    [SerializeField] private GameObject DispelButton3;

    private void Start()
    {
        CrumpledObject2.gameObject.SetActive(false);
        CrumpledObject3.gameObject.SetActive(false);

        FindDialogue.gameObject.SetActive(false);
        FindDialogue2.gameObject.SetActive(false);
        FindDialogue3.gameObject.SetActive(false);

        DispelButton.gameObject.SetActive(false);
        DispelButton2.gameObject.SetActive(false);
        DispelButton3.gameObject.SetActive(false);
    }
    public void DispelOBJ()
    {
        Destroy(CrumpledObject);
        FindDialogue.gameObject.SetActive(true);
        DispelButton.gameObject.SetActive(false);
    }

    public void DispelOBJ2()
    {
        Destroy(CrumpledObject2);
        FindDialogue2.gameObject.SetActive(true);
        DispelButton2.gameObject.SetActive(false);
    }    
    
    public void DispelOBJ3()
    {
        Destroy(CrumpledObject3);
        FindDialogue3.gameObject.SetActive(true);
        DispelButton3.gameObject.SetActive(false);
    }

}
