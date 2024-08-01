using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Level9 : MonoBehaviour
{
  public Button[] correctButtons;
    public Button[] wrongButtons;
    public Button submitButton;
    public GameObject winnerScreen;
    public GameObject Remove;
    public GameObject Remove1;

    private bool[] correctButtonStates;
    private bool anyWrongButtonPressed = false;

    private Color originalColor;
    private Color correctColor = Color.green;
    private Color wrongColor = Color.red;
    private Color pressedColor = Color.yellow;

    void Start()
    {
        correctButtonStates = new bool[correctButtons.Length];
        ResetButtons();

        foreach (var button in correctButtons)
        {
            button.onClick.AddListener(() => CorrectButtonPressed(button));
        }

        foreach (var button in wrongButtons)
        {
            button.onClick.AddListener(() => WrongButtonPressed(button));
        }

        submitButton.onClick.AddListener(SubmitButtonPressed);

        if (correctButtons.Length > 0)
        {
            originalColor = correctButtons[0].colors.normalColor;
        }
    }

    void CorrectButtonPressed(Button button)
    {
        int index = System.Array.IndexOf(correctButtons, button);
        if (index >= 0)
        {
            correctButtonStates[index] = true;
            SetButtonColor(button, pressedColor);
        }
    }

    void WrongButtonPressed(Button button)
    {
        anyWrongButtonPressed = true;
        SetButtonColor(button, pressedColor);
    }

    void SubmitButtonPressed()
    {
        if (anyWrongButtonPressed)
        {
            anyWrongButtonPressed = false;
            ResetButtons();
            return;
        }

        if (AllCorrectButtonsPressed())
        {
            foreach (var button in correctButtons)
            {
                SetButtonColor(button, correctColor);
            }
            winnerScreen.SetActive(true);
            Remove.SetActive(false);
            Remove1.SetActive(false);
        }
        else
        {
            ResetButtons();
        }
    }

    bool AllCorrectButtonsPressed()
    {
        foreach (bool state in correctButtonStates)
        {
            if (!state)
            {
                return false;
            }
        }
        return true;
    }

    void ResetButtons()
    {
        for (int i = 0; i < correctButtonStates.Length; i++)
        {
            correctButtonStates[i] = false;
        }
        anyWrongButtonPressed = false;

        foreach (var button in correctButtons)
        {
            SetButtonColor(button, originalColor);
        }

        foreach (var button in wrongButtons)
        {
            SetButtonColor(button, originalColor);
        }
    }

    void SetButtonColor(Button button, Color color)
    {
        ColorBlock cb = button.colors;
        cb.normalColor = color;
        cb.selectedColor = color;
        cb.highlightedColor = color;
        cb.pressedColor = color;
        button.colors = cb;
    }
}
