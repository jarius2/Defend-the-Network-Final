using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Level8 : MonoBehaviour
{
    public GameObject Correct;
    public GameObject Wrong1;
    public GameObject Wrong2;
    public GameObject Wrong3;
    public GameObject Submit;
    public GameObject Winnerscreen;
    public GameObject Remove;
    public GameObject Remove2;

    private Button correctButton;
    private Button wrongButton1;
    private Button wrongButton2;
    private Button wrongButton3;
    private Button submitButton;
    private Color originalColor;
    private bool isCorrectSelected = false;

    void Start()
    {
        correctButton = Correct.GetComponent<Button>();
        wrongButton1 = Wrong1.GetComponent<Button>();
        wrongButton2 = Wrong2.GetComponent<Button>();
        wrongButton3 = Wrong3.GetComponent<Button>();
        submitButton = Submit.GetComponent<Button>();

        originalColor = correctButton.image.color; // Assuming all buttons have the same original color

        correctButton.onClick.AddListener(() => OnButtonPress(correctButton, true));
        wrongButton1.onClick.AddListener(() => OnButtonPress(wrongButton1, false));
        wrongButton2.onClick.AddListener(() => OnButtonPress(wrongButton2, false));
        wrongButton3.onClick.AddListener(() => OnButtonPress(wrongButton3, false));
        submitButton.onClick.AddListener(OnSubmitPress);

        submitButton.interactable = false; // Initially disable the Submit button
    }

    void OnButtonPress(Button button, bool isCorrect)
    {
        // Reset all buttons to original color
        ResetButtonColors();

        // Change the color of the selected button
        button.image.color = Color.green;

        isCorrectSelected = isCorrect;

        // Enable the Submit button if the correct answer is selected
        submitButton.interactable = true;
    }

    void OnSubmitPress()
    {
        if (isCorrectSelected)
        {
            Winnerscreen.SetActive(true);
            Remove.SetActive(false);
            Remove2.SetActive(false);

        }
        else 
        {
            ResetButtonColors();
        }
    }

    void ResetButtonColors()
    {
        correctButton.image.color = originalColor;
        wrongButton1.image.color = originalColor;
        wrongButton2.image.color = originalColor;
        wrongButton3.image.color = originalColor;
    }
}