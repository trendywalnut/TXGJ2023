using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class SliderTextUpdate : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI sliderText;
    [SerializeField] private String nonValueText;
    private Slider slider;

    private void Awake() {
        slider = GetComponent<Slider>();
    }

    public void UpdateSliderText()
    {
        sliderText.text = nonValueText + " " + slider.value;
    }

    public void UpdateSliderTextNonValue() 
    {
        if (slider.value < 30) 
        {
            sliderText.text = nonValueText + " Loud Noises Scare Me";
        }
        else if (60 > slider.value && slider.value > 30)
        {
            sliderText.text = nonValueText + " I Like Some Sound";
        }
        else if (slider.value > 60 && slider.value < 90)
        {
            sliderText.text = nonValueText + " I Want To Face The Music";
        }
        else if (slider.value > 90)
        {
            sliderText.text = nonValueText + " I Was There When The Bombs Fell";
        }
    }

}
