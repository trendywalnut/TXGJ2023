using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ValidationBarFill : MonoBehaviour
{
    private Slider valBar;
    public UnityEvent barFilled;

    private bool hasBarFilled = false;
    void Start()
    {
        //barFilled = new UnityEvent();
        
        valBar = GetComponent<Slider>();
        valBar.value = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(valBar.value > 20)
        {
            valBar.value -= .1f;
        }

        if(valBar.value >= 99 && !hasBarFilled)
        {
            Completed();
            hasBarFilled = true;
        }
    }

    public void AddValue(int value)
    {
        valBar.value += value;
    }

    private void Completed()
    {
        barFilled.Invoke();
    }
}
