using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionComponent : MonoBehaviour
{
    MyInteractable interactable;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InteractWithInteractable();
        }
    }

    void InteractWithInteractable()
    {
        if (interactable != null && interactable.CanInteract())
        {
            interactable.Interact();
        }        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyInteractable>() != null)
            interactable = other.gameObject.GetComponent<MyInteractable>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<MyInteractable>() != null)
            interactable = null;
    }

}
