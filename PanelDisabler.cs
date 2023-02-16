using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelDisabler : MonoBehaviour
{
    public GameObject panel; 
    public GameObject button1; 
    public GameObject button2;
    public GameObject panelB; 
    public GameObject button3;
    public GameObject button4;
    public GameObject panelC;
    public GameObject button5;
    public GameObject button6;

    public void DisablePanel()
    {
        // Disable the panel, button1 and button2
        panel.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
    }
    public void DisablePanelB()
    {
        panelB.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
    }
    public void DisablePanelC()
    {
        panelC.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);
    }




}
