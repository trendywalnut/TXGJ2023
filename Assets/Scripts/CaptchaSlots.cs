using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptchaSlots : MonoBehaviour
{
    [SerializeField] private GameObject[] slotSprites;

    //public float spinLength;

    private float currentSpinLength;

    private int listIndex;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpinSlots(float spinLength)
    {
        currentSpinLength = 0;
        listIndex = 0;
        StartCoroutine(SlotCoroutine(spinLength));
    }

    IEnumerator SlotCoroutine(float spinLength)
    {
        foreach(GameObject sprite in slotSprites)
        {
            sprite.SetActive(false);
        }
        slotSprites[listIndex = (listIndex+1)%slotSprites.Length].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        currentSpinLength += 0.3f;
        if(currentSpinLength <= spinLength)
        {
            StartCoroutine(SlotCoroutine(spinLength));
        }
    }
}
