using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, MyInteractable
{
    float distanceToInteract;
    GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Start()
    {
        distanceToInteract = 2;
    }

    public bool CanInteract()
    {      
        var distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);

        if (distanceToPlayer < distanceToInteract)
        {
            return true;
        } 
        else
        {
            return false;
        }                
    }

    public void Interact()
    {
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", new Color(Random.value, Random.value, Random.value));
    }
}
