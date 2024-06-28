using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.SceneManagement;

public class DownloadBar : MonoBehaviour
{

    public GameObject bar;
    public int time;
    public GameObject Proceed;
    public GameObject Remove;
    public GameObject Remove_Bar;
    public GameObject Remove_BarBG;
    public GameObject Exit_Button;
   

    void Start()
    {
        AnimateBar();
    }

    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 1, time).setOnComplete(showMessage);
    }

    void showMessage()
    {
            Proceed.SetActive(true);
            Exit_Button.SetActive(true);
            Remove.SetActive(false);
            Remove_Bar.SetActive(false);
            Remove_BarBG.SetActive(false);
    }


}
