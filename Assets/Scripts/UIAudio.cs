using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAudio : MonoBehaviour {
    [SerializeField] private AudioClip UIHover;
    [SerializeField] private AudioClip UIClick;
    [SerializeField] private AudioClip UIConfirm;
    
    [SerializeField] private AudioSource _as;

    public void PlayUIHover() {
        _as.PlayOneShot(UIHover);
    }
    public void PlayUIClick() {
        _as.PlayOneShot(UIClick);
    }
    public void PlayUIConfirm() {
        _as.PlayOneShot(UIConfirm);
    }
}
