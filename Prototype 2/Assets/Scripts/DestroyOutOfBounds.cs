using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30.0f;
    private float lowerBoundary = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Removes game object when out of camera perspective
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBoundary)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
