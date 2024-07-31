using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Level6 : MonoBehaviour
{
    public TMP_InputField[] inputFields;
    public GameObject Winner;
    public GameObject Remove;
    public GameObject Remove2;
    public Color correctColor = Color.green;
    public Color wrongColor = Color.red;

    private string[] correctAnswers = new string[]
    {
        "Welcome to Ezone Group, we are pleased to have you in our company.", "User: secAnalyst12", "Pass: !default123",
        "We advise you to change the default password and set it to strong password.", "- Ciel"
    };

    private bool[] correctFlags;

    void Start()
    {
        correctFlags = new bool[inputFields.Length];
    }

    public void CheckAnswer(int index)
    {
        string userInput = inputFields[index].text;

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