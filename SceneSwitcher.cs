using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string sceneName; // The name of the scene to switch to
    public GameObject targetObject; // The object that the player must collide with to switch scenes

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player collided with the target object
        if (collision.gameObject == targetObject)
        {
            // Switch to the specified scene
            SceneManager.LoadScene(sceneName);
        }
        if (collision.gameObject.name =="invisWall2")
        {
            SceneManager.LoadScene("Scene12");
        }
    }
}

