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
    private Rigidbody2D rb;
    [SerializeField]private float bumpForce;
    [SerializeField] bool hasBallMoved;

    private void Start() 
    {
        difficultyText = GameObject.Find("DifficultyText").GetComponent<TextMeshProUGUI>();
        buttons = GameObject.FindGameObjectWithTag("Buttons");
        rb = GetComponent<Rigidbody2D>();
        buttons.SetActive(false);
        difficultyText.enabled = false;
        difficultyText.text = "";
    }

    private void LateUpdate() 
    {
        if (rb.velocity == Vector2.zero && hasBallMoved)
        {
            rb.AddForce(Vector2.one * bumpForce, ForceMode2D.Impulse);
        }
        if (rb.velocity != Vector2.zero){
            hasBallMoved = true;
        }        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        difficultyText.enabled = true;
        buttons.SetActive(true);
        switch (other.tag)
        {
            case "EasyDifficulty":
                textToShow = "Difficulty Selected:\nBaby's First Binky";
                difficultyText.text = textToShow;
                return;
            case "MediumDifficulty":
                textToShow = "Difficulty Selected:\nThis S*** Ain't Nothin' To Me Man!";
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
