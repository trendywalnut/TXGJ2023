using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EasyUI.PickerWheelUI;

public class PronounSpinner : MonoBehaviour
{
    [SerializeField] private Button spinButton;
    [SerializeField] private GameObject confirmButton;
    [SerializeField] private PickerWheel pickerWheel;

    // Start is called before the first frame update
    void Start()
    {
        confirmButton.SetActive(false);
        spinButton.onClick.AddListener(() =>
        {
            pickerWheel.Spin();

            pickerWheel.OnSpinEnd((PickerWheel) =>
            {
                confirmButton.SetActive(true);
            });
        });
    }
}
