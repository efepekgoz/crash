using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class buttonScene15 : MonoBehaviour
{

    public GameObject DialogBox,DialogBox2;
    public Text DialogText;
    public GameObject Button1,Button2;
    public GameObject Button3,Button4;
    public GameObject invisWall,invisWall2;

    public void b1click()
    {
        DialogText.text = "You rested, but it's time to go.";
        Button1.SetActive(false);
        Button2.SetActive(false);
        invisWall.SetActive(false);


}
    public void b2click()
    {
        DialogBox.SetActive(false);
        Button1.SetActive(false);
        Button2.SetActive(false);
        invisWall.SetActive(false);
    }
    public void b3click()
    {
        SceneManager.LoadScene("Scene27");
    }
    public void b4click()
    {
        DialogBox2.SetActive(false);
        Button3.SetActive(false);
        Button4.SetActive(false);
        invisWall2.SetActive(false);
    }
}
