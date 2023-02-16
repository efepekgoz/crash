using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // The character's transform
    public Transform target;
    // How close to the edge the character can get before the camera moves
    public float threshold = 0.1f;
    // The speed at which the camera moves
    public float cameraSpeed = 2f;
    // The camera's x-axis boundaries
    public Vector2 cameraBounds = new Vector2(-10f, 10f);

    private void Update()
    {
        // The character's x and y position
        float x = target.position.x;
        // The camera's x and y position
        float cameraX = transform.position.x;

        // Check if the character is outside the threshold on the right side
        if (x > cameraX + threshold)
        {
            // Move the camera to the right, but make sure it doesn't go outside the cameraBounds
            cameraX = Mathf.Lerp(cameraX, Mathf.Min(x - threshold, cameraBounds.y), cameraSpeed * Time.deltaTime);
        }
        // Check if the character is outside the threshold on the left side
        else if (x < cameraX - threshold)
        {
            // Move the camera to the left, but make sure it doesn't go outside the cameraBounds
            cameraX = Mathf.Lerp(cameraX, Mathf.Max(x + threshold, cameraBounds.x), cameraSpeed * Time.deltaTime);
        }

        // Update the camera's position, fixing the y axis to 0
        transform.position = new Vector3(cameraX, 0, transform.position.z);
    }
}