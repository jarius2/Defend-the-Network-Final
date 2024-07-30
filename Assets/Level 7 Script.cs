using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Level7Script : MonoBehaviour
{
    private string input;
    private const string CorrectAnswer = "GATHER AT THE MEETING ROOM IN THIRTY MINUTES";
    
    public GameObject Winner;
    public GameObject Remove;
    public GameObject Remove2;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ReadStringInput(string input)
    {
        Debug.Log(input);
        
        input = input.ToUpper();

        if (input == CorrectAnswer)
        {
          Winner.SetActive(true);
          Remove.SetActive(false);
          Remove2.SetActive(false);
        }

        else
        {
            Debug.Log("Wrong Answer.");

        }
    }

}
