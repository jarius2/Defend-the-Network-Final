using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelCompletion : MonoBehaviour
{
   public void Mainmenu()
   {
     SceneManager.LoadSceneAsync("Main Menu");
   }
    
    //Level 1
    public void Level1Done()
    {
        SceneManager.LoadSceneAsync("Level 2");
        UnlockNewLevel();
    }
    public void Level1Restart()
    {
        SceneManager.LoadSceneAsync("Level 1");
    }

    //Level 2
    public void Level2Done()
    {
        SceneManager.LoadSceneAsync("Level 3");
        UnlockNewLevel();
    }
    public void Level2Restart()
    {
        SceneManager.LoadSceneAsync("Level 2");
    }

    //Level 3
    public void Level3Done()
    {
        SceneManager.LoadSceneAsync("Level 4");
        UnlockNewLevel();
    }
    public void Level3Restart()
    {
        SceneManager.LoadSceneAsync("Level 3");
    }

    //Level 4
    public void Level4Done()
    {
        SceneManager.LoadSceneAsync("Level 5");
        UnlockNewLevel();
    }

    public void Level4Restart()
    {
        SceneManager.LoadSceneAsync("Level 4");
    }

    public void Level5Done()
    {
        SceneManager.LoadSceneAsync("Level 6");
        UnlockNewLevel();
     }

    public void Level5Restart()
    {
        SceneManager.LoadSceneAsync("Level 5");
    }

    public void Level6Done()
    {
        SceneManager.LoadSceneAsync("Level 7");
        UnlockNewLevel();
    }

    public void level6Restart()
    {
        SceneManager.LoadSceneAsync("Level 6");
    }

    public void Level7Done()
    {
        SceneManager.LoadSceneAsync("Level 8");
        UnlockNewLevel();
    }

    public void level7Restart()
    {
        SceneManager.LoadSceneAsync("Level 7");
    }

    public void Level8Done()
    {
        SceneManager.LoadSceneAsync("Level 9");
        UnlockNewLevel();
    }

    public void level8Restart()
    {
        SceneManager.LoadSceneAsync("Level 8");
    }

    public void Level9Done()
    {
        SceneManager.LoadSceneAsync("Level 10");
        UnlockNewLevel();
    }

    public void level9Restart()
    {
        SceneManager.LoadSceneAsync("Level 9");
    }

    public void Level10Done()
    {
        SceneManager.LoadSceneAsync("Level 11");
        UnlockNewLevel();
    }

    public void level10Restart()
    {
        SceneManager.LoadSceneAsync("Level 10");
    }








    void UnlockNewLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1 ) + 1);
            PlayerPrefs.Save();
        }
    }
}
