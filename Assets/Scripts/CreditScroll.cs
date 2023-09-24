using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditScroll : MonoBehaviour
{
    [SerializeField] private float timeToWait;
    [SerializeField] private float timeForExit;
    [SerializeField] private float scrollSpeed;
    [SerializeField] private GameObject exitButton;
    private bool isScrolling;

    private void Start() 
    {
        isScrolling = false;
        Invoke("StartScroll", timeToWait);
        Invoke("ShowExitButton", timeForExit);
    }

    private void Update()
    {
        if (isScrolling)
        {
            transform.position += Vector3.up * scrollSpeed;
        }
    }

    private void StartScroll()
    {
        isScrolling = true;
    }

    private void ShowExitButton()
    {
        exitButton.SetActive(true);
    }
}
