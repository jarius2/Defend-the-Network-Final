using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
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

      public void Level4()
    {
        SceneManager.LoadSceneAsync("Level 4.1");
    }

    public void Level5()
    {
        SceneManager.LoadSceneAsync("Level 5.1");
    }

     public void Level6()
    {
        SceneManager.LoadSceneAsync("Level 6.1");
    }
}
