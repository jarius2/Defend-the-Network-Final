using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadSceneAsync("A1");
    }
    public void level2()
    {
        SceneManager.LoadSceneAsync("A2");
    }
    public void Level3()
    {
        SceneManager.LoadSceneAsync("A3");
    }

      public void Level4()
    {
        SceneManager.LoadSceneAsync("Level 4.1");
    }

    public void Level5()
    {
        SceneManager.LoadSceneAsync("A5");
    }

    public void Level6()
    {
        SceneManager.LoadSceneAsync("A6");
    }

    public void Level7()
    {
        SceneManager.LoadSceneAsync("A7");
    }

    public void Level8()
    {
        SceneManager.LoadSceneAsync("A8");
    }

    public void Level9()
    {
        SceneManager.LoadSceneAsync("A9");
    }

    public void Level10()
    {
        SceneManager.LoadSceneAsync("A10");
    }
}