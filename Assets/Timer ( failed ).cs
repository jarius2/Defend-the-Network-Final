using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.SceneManagement;

public class TimerLevel3 : MonoBehaviour

{
    public GameObject bar;
    public int time;
   

    void Start()
    {
        AnimateBar();
    }

    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 1, time);
    }

    
}