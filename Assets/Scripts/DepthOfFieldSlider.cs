using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DepthOfFieldSlider : MonoBehaviour
{
    
    [SerializeField] private Slider slider;
    [SerializeField] private Material textMaterial;

    private void Awake() 
    {
        textMaterial = transform.parent.GetComponent<TextMeshProUGUI>().fontSharedMaterials[0];
        textMaterial.SetFloat("_OutlineSoftness", 0);
    }

    public void UpdateTextSoftness()
    {
        float softness = slider.value / 100f;
        textMaterial.SetFloat("_OutlineSoftness", softness);
    }

}
