using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger : MonoBehaviour
{

    public bool display;
    public bool mouseIn;
    public bool mouseOut;

    public string header;
    [Multiline()] public string content;

    public void Start()
    {
        display = false;
    }

    public void Displaying()
    {
        if (display == true && mouseIn == true && mouseOut == false)
        {   
            TooltipSystem.Show(content, header);
        }

        if(display == false && mouseIn == true && mouseOut == false)
        {
            TooltipSystem.Hide();
        }

        if (display == false && mouseIn == false && mouseOut == true)
        {
            TooltipSystem.Hide();
        }
    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!display)
            {
                if(mouseOut == false)
                {
                    display = true;
                }
            }

            else if (display == true) { 
            display = false;
            }
        }

        Displaying();
    }

    public void OnMouseEnter()
    {
        mouseIn = true;
        mouseOut = false;
    }


    public void OnMouseExit()
    {
        mouseIn = false;
        mouseOut = true;
    }

 }


/*
public int ButtonPressed = -1;
public int Displaying = 1;
public BoxCollider boxCollider;

public void Update()
{
    if (Input.GetKeyDown(KeyCode.E))
    {
        ButtonPressed *= -1;
        Displaying *= -1;
        Debug.Log(ButtonPressed);
    }
}

public void OnMouseEnter()
{

    float interactRange = 2f;
    Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
    foreach (Collider collider in colliderArray)
    {
        //Debug.Log(collider);

        if (ButtonPressed == 1)
        {

            TooltipSystem.Show();

        }

        if (ButtonPressed == -1)
        {

            TooltipSystem.Hide();

        }
    }

}


 * 
 * 
public bool ButtonPressed;
public BoxCollider boxCollider;

public void Update(){
    if (Input.GetKeyDown(KeyCode.E)){
        ButtonPressed = true;
        Debug.Log("Working");
    }
}

public void OnMouseEnter()
{
    if (ButtonPressed == true) {

        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            Debug.Log(collider);
            TooltipSystem.Show();
        }
    }
}

public void OnMouseExit()
{
    if (ButtonPressed == true) { 
        ButtonPressed = false;
        TooltipSystem.Hide();
    }
}
}



* using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger : MonoBehaviour
{
public bool ButtonPressed;

public void OnMouseEnter(){
        float interactRange = 10f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                ButtonPressed = true;
                Debug.Log(collider);
                TooltipSystem.Show();
            }
    }
}


public void OnMouseExit()
{
    {
        TooltipSystem.Hide();
        ButtonPressed = false;
    }
}
}
*/
