using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.SceneManagement;

public class Timer_Level3 : MonoBehaviour
{
    public GameObject bar;
    public int time;
    public List<GameObject> images; // List of image GameObjects to be activated

    void Start()
    {
        AnimateBar();
        StartCoroutine(ShowImagesEvery3Seconds());
    }

    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 1, time).setOnComplete(OnTimerComplete);
    }

    void OnTimerComplete()
    {
        // Actions to perform when the timer completes
    }

    IEnumerator ShowImagesEvery3Seconds()
    {
        int index = 0;

        while (true)
        {
            yield return new WaitForSeconds(3);

            if (index < images.Count)
            {
                images[index].SetActive(true); // Activate the next image
                index++;
            }
        }
    }
}
