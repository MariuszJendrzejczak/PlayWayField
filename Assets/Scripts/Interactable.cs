using System.Collections;
using System.Collections.Generic;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    protected float maxDistanceToPlayer = 1;
    private Transform _playerTransform;

    public virtual bool CanInteract()
    {
        return Vector3.Distance(this.transform.position, _playerTransform.position) <= maxDistanceToPlayer;
    }

    public virtual void Interact()
    {
            Debug.Log("Not ovverided Interact");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerInteractionScript.InteractWithInteractable += Interact;
            _playerTransform = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerInteractionScript.InteractWithInteractable -= Interact;
        }
    }
}
