using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CaptchaSlots : MonoBehaviour
{
    [SerializeField] private GameObject[] slotSprites;

    //public float spinLength;

    private float currentSpinLength;

    public int listIndex;
    public bool rolling = false;

    private void Start()
    {
        rolling = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpinSlots(float spinLength)
    {
        currentSpinLength = 0;
        listIndex = Random.Range(0, slotSprites.Length-1);
        StartCoroutine(SlotCoroutine(spinLength));
    }

    IEnumerator SlotCoroutine(float spinLength)
    {
        rolling = true;
        foreach(GameObject sprite in slotSprites)
        {
            sprite.SetActive(false);
        }
        slotSprites[listIndex = (listIndex+1)%slotSprites.Length].SetActive(true);
        yield return new WaitForSeconds(0.1f);
        rolling = false;
        currentSpinLength += 0.1f;
        if(currentSpinLength <= spinLength)
        {
            StartCoroutine(SlotCoroutine(spinLength));
        }
    }
}
