using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickAdvanceGame : MonoBehaviour
{
    //  USE ON A BUTTON ONLY PLS :)
    [SerializeField] private Button advanceButton;

    void Start()
    {
        advanceButton.onClick.AddListener(() => {
            MinigameManager.Instance.MoveToNextScene();
        });
    }
}
