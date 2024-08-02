using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Level4 : MonoBehaviour
{
    public TextMeshProUGUI Text1;
    public TextMeshProUGUI Text2;
    public TextMeshProUGUI Text3;

    public Button IntegrityButton;
    public Button RiskButton;
    public Button SecurityButton;
    public Button ConfidentialityButton;
    public Button AccessibilityButton;
    public Button HistoryButton;
    public Button SubmitButton;

    public GameObject Failed;
    public GameObject Game;
    public GameObject Success;
    public GameObject RemoveTimer;

    private int currentTextIndex = 1;
    private int attemptCount = 0;
    private const int maxAttempts = 2;
    public GameObject Try1;
    public GameObject Try2;

        void Start()
    {
        SubmitButton.gameObject.SetActive(false);
        Try1.gameObject.SetActive(false);
        Try2.gameObject.SetActive(false);
    }

    public void Integrity()
    {
        SetText("Integrity");
        IntegrityButton.gameObject.SetActive(false); 
    }

    public void Risk()
    {
        SetText("Risk");
        RiskButton.gameObject.SetActive(false); 
    }

    public void Security()
    {
        SetText("Security");
        SecurityButton.gameObject.SetActive(false); 
    }

    public void Confidentiality()
    {
        SetText("Confidentiality");
        ConfidentialityButton.gameObject.SetActive(false); 
    }

    public void Accessibility()
    {
        SetText("Accessibility");
        AccessibilityButton.gameObject.SetActive(false); 
    }

    public void History()
    {
        SetText("History");
        HistoryButton.gameObject.SetActive(false); 
    }

    private void SetText(string newText)
    {
        switch (currentTextIndex)
        {
            case 1:
                Text1.text = newText;
                break;
            case 2:
                Text2.text = newText;
                break;
            case 3:
                Text3.text = newText;
                break;
        }

        currentTextIndex++;

        if (currentTextIndex > 3)
        {
            SubmitButton.gameObject.SetActive(true);
            IntegrityButton.gameObject.SetActive(false);
            RiskButton.gameObject.SetActive(false);
            SecurityButton.gameObject.SetActive(false);
            ConfidentialityButton.gameObject.SetActive(false);
            AccessibilityButton.gameObject.SetActive(false);
            HistoryButton.gameObject.SetActive(false);
        }
    }

     public void Submit()
    {
        if (attemptCount >= maxAttempts)
        {
            Debug.Log("You have exceeded the maximum number of attempts. You have failed");
            Game.gameObject.SetActive(false);
            Failed.gameObject.SetActive(true);
            RemoveTimer.gameObject.SetActive(false);
        }

        attemptCount++; 
        Debug.Log("Attempt " + attemptCount);
        
        if(attemptCount == 1)
        {
            Try1.gameObject.SetActive(true);
        }

        if(attemptCount == 2)
        {
            Try1.gameObject.SetActive(false);
            Try2.gameObject.SetActive(true);
        }
        
        CheckOrder();
    }

    private void CheckOrder()
    {
        if (Text1.text == "Confidentiality" && Text2.text == "Integrity" && Text3.text == "Accessibility")
        {
            Success.gameObject.SetActive(true);
            Game.gameObject.SetActive(false);
            RemoveTimer.gameObject.SetActive(false);
        }

        else
        {
            Debug.Log("Incorrect");
            ResetButtonsAndText();
        }
    }

    private void ResetButtonsAndText()
    {
        // Reset the index for the next attempt
        currentTextIndex = 1;

        // Clear the text fields
        Text1.text = "1........";
        Text2.text = "2........";
        Text3.text = "3........";

        // Show all the buttons again
        IntegrityButton.gameObject.SetActive(true);
        RiskButton.gameObject.SetActive(true);
        SecurityButton.gameObject.SetActive(true);
        ConfidentialityButton.gameObject.SetActive(true);
        AccessibilityButton.gameObject.SetActive(true);
        HistoryButton.gameObject.SetActive(true);

        SubmitButton.gameObject.SetActive(false);
    }

    

}