using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Interactable
{
    private GameObject _player;

    public override void Interact()
    {
        if(CanInteract())
        {
            Debug.Log("Interaction with Capsule");
        }
    }
}
