using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchGame : MonoBehaviour
{
    [SerializeField] private GameObject[] textPopups;

    private void Start() {
        
    }

    public void StartGameLaunchSequence() {
        StartCoroutine(EnableText(0));
    }

    IEnumerator EnableText(int index) {
        textPopups[index].SetActive(true);
        yield return new WaitForSeconds(2);
        
        textPopups[index].SetActive(false);
        index++;
        if (index <= textPopups.Length - 1) {
            StartCoroutine(EnableText(index));
        }
        else {
            Debug.Log("move to next step");
        }
    }
}
