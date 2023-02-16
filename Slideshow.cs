using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slideshow : MonoBehaviour, IPointerClickHandler
{
    // list of images
    public List<Sprite> images;
    // the image component to display the images
    public Image image;
    // the text component to display the descriptions
    public Text description;
    // the list of descriptions for each image
    public List<string> descriptions;
    // the index of the current image
    public int currentIndex = 0;
    // the time it takes for the images to fade in and out
    public float fadeTime = 1f;
    // the two button objects
    public GameObject button1;
    public GameObject button2;

    void Start()
    {
        // set the initial image
        image.sprite = images[currentIndex];
        // set the initial description
        description.text = descriptions[currentIndex];
        // fade in the initial image
        image.CrossFadeAlpha(1, fadeTime, false);
        // deactivate the two buttons initially
        button1.SetActive(false);
        button2.SetActive(false);
    }

    // function to switch to the next image
    public void NextImage()
    {
        StartCoroutine(FadeOut());
    }

    // coroutine to fade out the current image
    IEnumerator FadeOut()
    {
        image.CrossFadeAlpha(0, fadeTime, false);
        // wait for the fade time before switching to the next image
        yield return new WaitForSeconds(fadeTime);
        currentIndex++;
        // if the last image is reached, go back to the first image
        if (currentIndex >= images.Count)
        {
            currentIndex = 0;
        }
        // switch to the next image
        image.sprite = images[currentIndex];
        // switch to the next description
        description.text = descriptions[currentIndex];
        // activate the buttons if the 4th image is displayed
        if (currentIndex == 3)
        {
            button1.SetActive(true);
            button2.SetActive(true);
        }
        // deactivate the buttons if not the 4th image
        else
        {
            button1.SetActive(false);
            button2.SetActive(false);
        }
        // start the coroutine to fade in the next image
        StartCoroutine(FadeIn());
    }

    // coroutine to fade in the next image
    IEnumerator FadeIn()
    {
        image.CrossFadeAlpha(1, fadeTime, false);
        // wait for the fade time before ending the coroutine
        yield return new WaitForSeconds(fadeTime);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        NextImage();
    }
}
