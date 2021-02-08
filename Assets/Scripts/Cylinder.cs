using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Interactable
{
    

    public override void Interact()
    {
        if(CanInteract())
        {
            Debug.Log("Interaction with Cylinder");
        }
    }
}
