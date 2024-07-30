using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level10 : MonoBehaviour
{
    public TMP_InputField[] inputFields;
    public GameObject Winner;
    public GameObject Remove;
    public GameObject Remove2;
    public Color correctColor = Color.green;
    public Color wrongColor = Color.red;

    private string[] correctAnswers = new string[]
    {
        "RANSOMWARE", "MITIGATE", "HIGH ALERT", "DEVICES", "IMMEDIATELY", "PAYMENT", 
        "ENCRYPTED", "SUDDEN", "UNAUTHORIZED", "DISCONNECT", "IMMEDIATELY", "SHUTDOWN", 
        "PREVENT", "DEMANDED", "NO GUARANTEE", "CRIMINAL ACTIVITIES"
    };

    private bool[] correctFlags;

    void Start()
    {
        correctFlags = new bool[inputFields.Length];
    }

    public void CheckAnswer(int index)
    {
        string userInput = inputFields[index].text.ToUpper();

        if (userInput == correctAnswers[index])
        {
            inputFields[index].image.color = correctColor;
            inputFields[index].interactable = false;
            correctFlags[index] = true;
        }
        else
        {
            inputFields[index].image.color = wrongColor;
            correctFlags[index] = false;
        }

        if (AllAnswersCorrect())
        {
            Winner.SetActive(true);
            Remove.SetActive(false);
            Remove2.SetActive(false);
        }
    }

    private bool AllAnswersCorrect()
    {
        foreach (bool flag in correctFlags)
        {
            if (!flag)
            {
                return false;
            }
        }
        return true;
    }
}