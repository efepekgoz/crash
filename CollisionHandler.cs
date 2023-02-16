using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public int j = 0; // Declare an integer variable j and initialize it to 0


   

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "invisWall3") // Check if the object that collided with the player has the "Tree" tag
        {
            j = 1; // Set j to 1 if the collision was with a tree object
            Debug.Log("Do something here");
        }
    }
}
