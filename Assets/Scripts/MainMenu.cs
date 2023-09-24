using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject CreditsPanel;
    [SerializeField] private GameObject[] UIButtons;
    [SerializeField] private float WaitBetweenButtons = .7f;
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
    void Start() 
    {
        StartCoroutine(UILoadIn());
    }
    private IEnumerator UILoadIn()
    {
        foreach(GameObject button in UIButtons)
        {
            yield return new WaitForSeconds(WaitBetweenButtons);
            button.SetActive(true);
        }
    }
}
