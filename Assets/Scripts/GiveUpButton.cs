using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GiveUpButton : MonoBehaviour
{
    [SerializeField] private GameObject giveUpButton;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Image image;
    public int counter;

    private bool counterFinished = false;

    private float alpha = 0;
    void Start()
    {
        giveUpButton.SetActive(false);
        counterFinished = false;
    }
    private void Update()
    {
        image.color = new Color(255, 255, 255, alpha);
        if((counter >= 10) && !counterFinished)
        {
            giveUpButton.SetActive(true);
            audioSource.Play();
            counterFinished = true;
            MusicFade();
        }
    }

    public void IncreaseCount()
    {
        counter++;
    }
    private void MusicFade()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(DOTween.To(() => alpha, x => alpha = x, 1, 2));
        sequence.PrependInterval(1);
        sequence.Append(DOTween.To(() => alpha, x => alpha = x, 0, 2));

    }
}
