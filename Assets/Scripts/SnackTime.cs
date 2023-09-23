using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnackTime : MonoBehaviour
{
    [SerializeField] private int NumRequiredClicks = 20;

    private float FillPerClick;
    private Image ImageComponent;


    private void Start()
    {
        FillPerClick = 1.0f / NumRequiredClicks;
        ImageComponent = GetComponent<Image>();
    }

    public void OnSnackClicked()
    {
        ImageComponent.fillAmount -= FillPerClick;
        if(Mathf.Approximately(ImageComponent.fillAmount, 0.0f))
        {
            MinigameManager.Instance.MoveToNextScene();
        }
    }
}
