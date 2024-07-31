using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Level9 : MonoBehaviour
{
    public GameObject Correct1;
    public GameObject Correct2;
    public GameObject Correct3;
    public GameObject Wrong1;
    public GameObject Wrong2;
    public GameObject Wrong3;
    public GameObject Wrong4;
    public GameObject Submit;
    public GameObject Winnerscreen;
    public GameObject Remove;
    public GameObject Remove2;

    private Button[] correctButtons;
    private Button[] wrongButtons;
    private Button submitButton;
    private Color originalColor;
    private int correctButtonCount = 0;
    private bool hasAnyWrongButtonBeenPressed = false; // Track if any wrong button has been pressed
    private const int requiredCorrectCount = 3;

    void Start()
    {
        // Initialize buttons
        correctButtons = new Button[]
        {
            Correct1.GetComponent<Button>(),
            Correct2.GetComponent<Button>(),
            Correct3.GetComponent<Button>(),
        };

        wrongButtons = new Button[]
        {
            Wrong1.GetComponent<Button>(),
            Wrong2.GetComponent<Button>(),
            Wrong3.GetComponent<Button>(),
            Wrong4.GetComponent<Button>(),
        };

        submitButton = Submit.GetComponent<Button>();
        originalColor = correctButtons[0].image.color; // Assuming all buttons have the same original color

        // Add listeners for correct buttons
        foreach (var button in correctButtons)
        {
            button.onClick.AddListener(() => OnButtonPress(true));
        }

        // Add listeners for wrong buttons
        foreach (var button in wrongButtons)
        {
            button.onClick.AddListener(() => OnWrongButtonPress());
        }

        submitButton.onClick.AddListener(OnSubmitPress);
        submitButton.interactable = true; // Enable the Submit button regardless of button selections
    }

    void OnButtonPress(bool isCorrect)
    {
        // Change the color of the selected button
        Button button = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        button.image.color = isCorrect ? Color.green : Color.red;

        // Update button state
        if (isCorrect)
        {
            correctButtonCount++;
        }
    }

    void OnWrongButtonPress()
    {
        // Change the color of the wrong button
        Button button = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        button.image.color = Color.red;

        // Update flag for wrong button pressed
        hasAnyWrongButtonBeenPressed = true;
    }

    void OnSubmitPress()
    {
        if (hasAnyWrongButtonBeenPressed)
        {
            // Reset button colors if any wrong button was pressed
            ResetButtonColors();
            correctButtonCount = 0; // Reset correct button count
        }
        else if (correctButtonCount == requiredCorrectCount)
        {
            Winnerscreen.SetActive(true);
            Remove.SetActive(false);
            Remove2.SetActive(false);
        }
        else
        {
            ResetButtonColors();
            correctButtonCount = 0; // Reset correct button count
        }

        // Disable the Submit button after submitting
        submitButton.interactable = false;
    }

    void ResetButtonColors()
    {
        // Reset colors for correct buttons
        foreach (var button in correctButtons)
        {
            button.image.color = originalColor;
        }

        // Reset colors for wrong buttons
        foreach (var button in wrongButtons)
        {
            button.image.color = originalColor;
        }

        // Reset flags
        hasAnyWrongButtonBeenPressed = false;
    }
}
