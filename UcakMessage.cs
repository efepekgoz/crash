using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import the UI namespace

public class UcakMessage : MonoBehaviour
{
    // Declare a public reference to the panel game object
    public GameObject panel;
    public GameObject panel2;
    public GameObject invisWall,invisWall2;
    public GameObject Button1,Button3;
    public int i = 0;
    

    // Declare a public variable for the target position
    public Vector2 targetPosition;
    

    // Declare a public variable for the distance threshold
    public float distanceThreshold = 2.0f;
    

    void Start()
    {
        // Set the panel game object to inactive so it is not visible
        panel.SetActive(false);
        
        

        // Set the x axis of the target position to -4.45
        targetPosition.x = -3.60f;
       
    }

    public void panelStart()
    {
        if (i == 0)
        {
            panel.SetActive(true);
            i=1; 
        }
    }
    

    void Update()
    {
        // Calculate the distance between the player and the target position
        float distance = Vector2.Distance(transform.position, targetPosition);

        // If the distance is less than the threshold, display the message
        if (distance < distanceThreshold)
        {
            panelStart();
        }
        if (Button1.gameObject.activeInHierarchy)
        {
            invisWall.SetActive(true);
        }

   

    }
}