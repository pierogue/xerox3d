using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    void Start()
    {
        
    }

    public Vector3 rotationSpeed = new Vector3(0, 0, 100); // Rotation speed in degrees per second
    private bool isRotating = false; // Toggle for rotation

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isRotating = !isRotating;
        }

        // Apply rotation if toggled on
        if (isRotating)
        {
            transform.Rotate(rotationSpeed * Time.deltaTime);
        }
    }
}
