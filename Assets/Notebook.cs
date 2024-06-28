using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Notebook : MonoBehaviour
{
    public void BackMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
    