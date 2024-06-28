using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    }
    public void Level1Restart()
    {
        SceneManager.LoadSceneAsync("Level 1");
    }

    //Level 2
    public void Level2Done()
    {
        SceneManager.LoadSceneAsync("Level 3");
    }
    public void Level2Restart()
    {
        SceneManager.LoadSceneAsync("Level 2");
    }

    //Level 3
    public void Level3Done()
    {
        SceneManager.LoadSceneAsync("Level 4");
    }
    public void Level3Restart()
    {
        SceneManager.LoadSceneAsync("Level 3");
    }
}
