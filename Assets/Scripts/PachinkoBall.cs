using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PachinkoBall : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI difficultyText;
    [SerializeField] private String textToShow;
    [SerializeField] private GameObject buttons;

    private void Start() 
    {
        difficultyText = GameObject.Find("DifficultyText").GetComponent<TextMeshProUGUI>();
        buttons = GameObject.FindGameObjectWithTag("Buttons");
        buttons.SetActive(false);
        difficultyText.text = "";    
    }

    private void OnTriggerEnter2D(Collider2D other) {
        buttons.SetActive(true);
        switch (other.tag)
        {
            case "EasyDifficulty":
                textToShow = "Difficulty Selected:\nBaby's First Binky";
                difficultyText.text = textToShow;
                return;
            case "MediumDifficulty":
                textToShow = "Difficulty Selected:\nI Can Game!";
                difficultyText.text = textToShow;
                return;
            case "HardDifficulty":
                textToShow = "Difficulty Selected:\nI Beat Sekiro";
                difficultyText.text = textToShow;
                return;
            case "UltraDifficulty":
                textToShow = "Difficulty Selected:\nF*** My A**";
                difficultyText.text = textToShow;
                return;
            default:
                Debug.Log("No Tag Detected");
                return;
        }
    }
}
