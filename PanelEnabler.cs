using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelEnabler : MonoBehaviour
{
    public GameObject targetObject; // The object that the player must collide with
    public GameObject panel; // The panel to enable
    public GameObject button1; // The first button to enable
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject panelB;
    public GameObject button5;
    public GameObject button6;
    public GameObject panelC;
    public GameObject swapObject1;
    public GameObject swapObject2;
    public GameObject swapObject3;

  /*  void Start()
    {
        panelB = GameObject.Find("PanelB"); 
    }
    */

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player collided with the target object
        if (collision.gameObject == targetObject)
        {
            // Enable the panel, button1 and button2
            panel.SetActive(true);
            button1.SetActive(true);
            button2.SetActive(true);
        }
        if (collision.gameObject.name == "invisWallBear")
        {
            targetObject.SetActive(false);
            swapObject2.SetActive(true);
        }
        if (collision.gameObject.name == "invisWallBerry")
        {
            panelB.SetActive(true);
            button3.SetActive(true);
            button4.SetActive(true);
            swapObject1.SetActive(true);
            swapObject2.SetActive(false);
        }
        if (collision.gameObject.name == "invisWallLake")
        {
            panelC.SetActive(true);
            button5.SetActive(true);
            button6.SetActive(true);
            swapObject3.SetActive(false);
        }
    
    }
}
