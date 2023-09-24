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
        difficultyText.enabled = false;
        difficultyText.text = "";    
    }

    private void OnTriggerEnter2D(Collider2D other) {
        difficultyText.enabled = true;
        buttons.SetActive(true);
        switch (other.tag)
        {
            case "EasyDifficulty":
                textToShow = "{diagexp}Difficulty Selected:\nBaby's First Binky{/diagexp}";
                difficultyText.text = textToShow;
                return;
            case "MediumDifficulty":
                textToShow = "{diagexp}Difficulty Selected:\nThis S*** Ain't Nothin' To Me Man!{/diagexp}";
                difficultyText.text = textToShow;
                return;
            case "HardDifficulty":
                textToShow = "{diagexp}Difficulty Selected:\nI Beat Sekiro{/diagexp}";
                difficultyText.text = textToShow;
                return;
            case "UltraDifficulty":
                textToShow = "{diagexp}Difficulty Selected:\nF*** My A**{/diagexp}";
                difficultyText.text = textToShow;
                return;
            default:
                Debug.Log("No Tag Detected");
                return;
        }
    }
}
