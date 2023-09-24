using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnackTime : MonoBehaviour
{
    [SerializeField] private int NumRequiredClicks = 20;
    [SerializeField] private int PercentForFirstClick = 50;

    private float FirstClickFill;
    private float FillPerRemainingClicks;
    private int NumClicks;
    private Image ImageComponent;

    private void Start()
    {
        FirstClickFill = PercentForFirstClick / 100.0f;
        FillPerRemainingClicks =  (1.0f - FirstClickFill) / NumRequiredClicks;
        NumClicks = 0;
        ImageComponent = GetComponent<Image>();
    }

    public void OnSnackClicked()
    {
        float initialFillAmount = ImageComponent.fillAmount;
        float fillToSubtract = Mathf.Approximately(initialFillAmount, 1.0f) ? FirstClickFill : FillPerRemainingClicks;
        if(Mathf.Approximately(initialFillAmount, 1.0f))
        {
            fillToSubtract = FirstClickFill;
        }
        else
        {
            fillToSubtract = FillPerRemainingClicks;
            NumClicks++;
        }
        ImageComponent.fillAmount -= fillToSubtract;

        if(NumClicks == NumRequiredClicks || ImageComponent.fillAmount <= 0.1f)
        {
            MinigameManager.Instance.MoveToNextScene();
        }
    }
}
