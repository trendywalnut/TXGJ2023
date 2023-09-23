using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotsWinCondition : MonoBehaviour
{
    [SerializeField] GameObject rollButton;
    [SerializeField] GameObject rollText;
    [SerializeField] GameObject winButton;
    [SerializeField] GameObject winText;

    [SerializeField] private CaptchaSlots slot1;
    [SerializeField] private CaptchaSlots slot2;
    [SerializeField] private CaptchaSlots slot3;
    void Start()
    {
        rollButton.SetActive(true);
        rollText.SetActive(true);
        winText.SetActive(false);
        winButton.SetActive(false);
    }

    private void Update()
    {
        if (!slot1.rolling && !slot2.rolling && !slot3.rolling && slot1.listIndex == slot2.listIndex && slot2.listIndex == slot3.listIndex)
        {
            rollButton.SetActive(false);
            rollText.SetActive(false);
            winText.SetActive(true);
            winButton.SetActive(true);
        }
    }
    
}
