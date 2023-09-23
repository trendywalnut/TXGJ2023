using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomFOVButton : MonoBehaviour
{
    
    [SerializeField] private Slider fovSlider;
    [SerializeField] private TextMeshProUGUI fovText;

    private int currentFov;

    public void RandomizeFOV() 
    {
        currentFov = Random.Range(1, 100);
        fovSlider.value = currentFov;
    }

    public void UpdateFOVText()
    {
        fovText.text = "FOV: " + currentFov;
    }

}
