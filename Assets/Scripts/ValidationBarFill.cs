using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidationBarFill : MonoBehaviour
{
    private Slider valBar;
    void Start()
    {
        valBar = GetComponent<Slider>();
        valBar.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(valBar.value > 20)
        {
            valBar.value -= 0.01f;
        }

        if(valBar.value == 100)
        {
            Completed();
        }
    }

    public void AddValue(int value)
    {
        valBar.value += value;
    }

    private void Completed()
    {

    }
}
