using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ActivatorObject : MonoBehaviour
{
    public GameObject DialogBox;
    public Text DialogText;
    public int i = 0;
    public GameObject Button1, Button2;
    

    public void Start()
    {

     

        StartCoroutine(ActivationRoutine());



        IEnumerator ActivationRoutine()
        {

            //Wait for 5 secs.
            yield return new WaitForSeconds(2);

            //Turn My game object that is set to false(off) to True(on).
            // DialogText.text = "hello 123";
            //DialogBox.SetActive(true);

            switch (i)
            {
                case 0:
                    DialogText.text = "You are in a small plane, going across Rocky Mountains.";
                    DialogBox.SetActive(true);
                    break;
                case 1:
                    DialogText.text = "Suddenly the engine starts to make strange noises and the plane begins to go down.";
                    DialogBox.SetActive(true);
                    break;
                case 2:
                    DialogText.text = "Your radio does not work and nobody knows where you are.";
                    DialogBox.SetActive(true);
                    break;
                case 3:
                    DialogText.text = "You are going into mountains but you can steer north or south.";
                    DialogBox.SetActive(true);
                    break;
                case 4:
                    Button1.SetActive(true);
                    Button2.SetActive(true);
                    break;
            }
            i++;
        }
    }

        void Update()
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                DialogBox.SetActive(false);
                Start();
            } 

        }
    
}
