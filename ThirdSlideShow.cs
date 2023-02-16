using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ThirdSlideShow : MonoBehaviour, IPointerClickHandler
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
    public GameObject panel;
    public GameObject image1;
    public GameObject credits;

    void Start()
    {
        // set the initial image
        image.sprite = images[currentIndex];
        // set the initial description
        description.text = descriptions[currentIndex];
        // fade in the initial image
        image.CrossFadeAlpha(1, fadeTime, false);
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
        // start the coroutine to fade in the next image
        StartCoroutine(FadeIn());

        if (currentIndex == 4)
        {
            SceneManager.LoadScene("MainMenu"); 
        }

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
