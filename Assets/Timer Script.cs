using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class TimerScript : MonoBehaviour

{
    public GameObject bar;
    public int time;
    public GameObject Fail;
    public GameObject Remove;
    public GameObject Remove2;
    

    void Start()
    {
        AnimateBar();
    }

    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 1, time).setOnComplete(OnAnimationComplete);
    }

    void OnAnimationComplete()
    {
        Fail.SetActive(true);
        Remove.SetActive(false);
        Remove2.SetActive(false);
    }

    


}
