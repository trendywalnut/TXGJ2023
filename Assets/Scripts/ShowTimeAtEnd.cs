using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowTimeAtEnd : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI thanksText;

    private void Start() {
        TimeSpan timeTaken = MinigameManager.Instance.ElapsedTime;
        thanksText.text += "\n Final Time:\n" + string.Format("{0:00}:{1:00}:{2:00}", timeTaken.Hours, timeTaken.Minutes, timeTaken.Seconds);
    }
}
