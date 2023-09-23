using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class TextureDropDown : MonoBehaviour
{
    
    [SerializeField] private TMP_Dropdown dropdown;

    private void Start() 
    {
        dropdown = GetComponent<TMP_Dropdown>();
        dropdown.onValueChanged.AddListener(delegate {
            ValueChanged(dropdown);
        });
        Screen.SetResolution(1920, 1080, true);
    }

    private void ValueChanged(TMP_Dropdown dropdown)
    {
        switch (dropdown.value)
        {
            case 0:
                Screen.SetResolution(320, 180, true);
                Debug.Log("Lowest Texture");
                return;
            case 1:
                Screen.SetResolution(1920, 1080, true);
                return;
            case 2:
                Screen.SetResolution(2560, 1440, true);
                return;
            default:
                Debug.Log(dropdown.value);
                return;
        }
    }
}
