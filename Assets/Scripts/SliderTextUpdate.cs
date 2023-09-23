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

    public void UpdateSliderText()
    {
        sliderText.text = nonValueText + " " + GetComponent<Slider>().value;
    }

}
