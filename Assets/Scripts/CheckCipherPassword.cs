using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using DG.Tweening;

public class CheckCipherPassword : MonoBehaviour
{
    
    [SerializeField] private String password;
    [SerializeField] private TMP_InputField input;
    [SerializeField] private TextMeshProUGUI noText;
    public UnityEvent wrongPassword;

    public void CheckPassword()
    {
        String enteredPassword = input.text.ToLower();
        if (enteredPassword.Equals(password))
        {
            MinigameManager.Instance.MoveToNextScene();
        }
        else
        {
            Debug.Log("NO!");
            StartCoroutine(AnimateNoText());
        }
    }

    IEnumerator AnimateNoText()
    {
        noText.gameObject.SetActive(true);
        noText.DOFade(1, 1f);
        noText.rectTransform.DOPunchScale(new Vector3(1.5f, 1.5f, 1.5f), 2);

        yield return new WaitForSeconds(2);
        noText.DOFade(0, 1f);
        yield return new WaitForSeconds(1);
        noText.gameObject.SetActive(false);
    }

}
