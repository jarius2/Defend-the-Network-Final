using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    //Level 1
    public void Level1()
    {
        SceneManager.LoadSceneAsync("Level 1.1");
    }

    public void level2()
    {
        SceneManager.LoadSceneAsync("Level 2.1");
    }

    public void Level3()
    {
        SceneManager.LoadSceneAsync("Level 3.1");
    }
}
