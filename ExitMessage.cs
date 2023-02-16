using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitMessage : MonoBehaviour
{
    // Declare a public reference to the panel game object
    public GameObject panel;
    public GameObject invisWall2;
    public GameObject Button3, Button4;
    int i = 0;

    // Declare a boolean variable to track whether the message has been displayed
    private bool messageDisplayed = false;

    // Declare a public variable for the target position
    public Vector2 targetPosition;
    public Vector2 resetPosition;

    // Declare a public variable for the distance threshold
    public float distanceThreshold = 0.1f;

    void Start()
    {
        // Set the panel game object to inactive so it is not visible
        panel.SetActive(false);

        // Set the x axis of the target position to -4.45
        targetPosition.x = 6.50f;
        resetPosition.x = 4.05f;
    }

    public void panelStart()
    {
        if (i == 0)
        {
            panel.SetActive(true);
            Button3.SetActive(true);
            Button4.SetActive(true);
            i = 1;
        }
    }

void Update()
    {
        // Calculate the distance between the player and the target position
        float distance = Vector2.Distance(transform.position, targetPosition);
        float distance2 = Vector2.Distance(transform.position, resetPosition);

        // If the distance is less than the threshold, display the message
        if (distance < distanceThreshold)
        {
            panelStart();
        }

        if (Button3.gameObject.activeInHierarchy)
        {
            invisWall2.SetActive(true);
        }
    }
}