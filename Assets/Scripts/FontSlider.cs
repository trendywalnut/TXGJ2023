using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontSlider : MonoBehaviour
{
    [SerializeField] private Slider ValueSlider;
    [SerializeField] private TMPro.TMP_Text Title;
    [SerializeField] private TMPro.TMP_Text FontValue;

    // Start is called before the first frame update
    void Start()
    {
        ValueSlider.onValueChanged.AddListener(delegate { OnSliderValueChanged(); });
    }

    public void OnSliderValueChanged()
    {
        var newFontSize = ValueSlider.value;
        Title.fontSize = newFontSize;
        FontValue.fontSize = newFontSize;
        FontValue.text = newFontSize.ToString();
    }
}
