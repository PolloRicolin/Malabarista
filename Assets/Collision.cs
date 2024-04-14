using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionEffect : MonoBehaviour
{
    public float tumbleSpeed = 10f; 
    public GameObject objectToChange;

    void OnTriggerEnter(Collider other)
    {
        if (objectToChange != null && objectToChange.GetComponent<Renderer>() != null)
        {
            objectToChange.transform.Rotate(0f, 0f, -tumbleSpeed * Time.deltaTime, Space.World);
            objectToChange.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            Debug.LogError("No object assigned to change or missing Renderer component!");
        }
    }
}



