using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionScript : MonoBehaviour
{
    public static Action InteractWithInteractable;
    public static void CallInteractWithInteractabe()
    {
        InteractWithInteractable();
    }

    private void Update()
    {
        if (InteractWithInteractable != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                CallInteractWithInteractabe();
            }  
        }
        
    }
}
