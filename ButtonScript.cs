using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // Declare a reference to the panel game object
    public GameObject panel;
    public GameObject Button3, Button4;

    // Use the OnClick event to specify a method to be called when the button is clicked
    public void OnClick()
    {
        // Deactivate the panel and buttons
        panel.SetActive(false);
        Button3.SetActive(false);
        Button4.SetActive(false);
    }
}