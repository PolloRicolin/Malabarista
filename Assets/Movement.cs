using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderTumble : MonoBehaviour
{
    public float tumbleSpeed = 10f; 

    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;

        if (Input.GetKey(KeyCode.LeftArrow) && (currentRotation.x>60))
        {
            transform.Rotate(0f, 0f, tumbleSpeed * Time.deltaTime, Space.World);
        }

        else if (Input.GetKey(KeyCode.RightArrow) && (currentRotation.x>60))
        {
            transform.Rotate(0f, 0f, -tumbleSpeed * Time.deltaTime, Space.World);
        }
    }
}



