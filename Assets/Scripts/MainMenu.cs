using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject CreditsPanel;

    public void OnBegin()
    {
        MinigameManager.Instance.MoveToNextScene();
    }

    public void OnCredits()
    {
        CreditsPanel.SetActive(true);
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void OnCreditsExit()
    {
        CreditsPanel.SetActive(false);
    }
}
