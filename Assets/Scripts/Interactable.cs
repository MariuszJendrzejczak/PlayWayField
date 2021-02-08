using System.Collections;
using System.Collections.Generic;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    protected float maxDistanceToPlayer = 1;
    private GameObject _player;

    private void Start()
    {
        _player = GameObject.Find("Player");
    }
    public virtual bool CanInteract()
    {
        return Vector3.Distance(this.transform.position, _player.transform.position) <= maxDistanceToPlayer;
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
