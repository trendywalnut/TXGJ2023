using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class GenericButtonTweener : MonoBehaviour
{
    [SerializeField][Range(0,2)] private float ButtonHoverScale = 1.12f;
    [SerializeField][Range(0,2)] private float ButtonHoverScaleTime = 0.2f;
    [SerializeField][Range(-90,90)] private float ButtonRotateAmount = 0f;
    [SerializeField] private AnimationCurve ButtonHoverScaleCurve;
    [SerializeField] private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnHoverEnterTween(Button button)
    {
        button.GetComponent<RectTransform>().DOScale(ButtonHoverScale,ButtonHoverScaleTime).SetEase(ButtonHoverScaleCurve);
        button.GetComponent<RectTransform>().DORotate(new Vector3(0,0,ButtonRotateAmount), ButtonHoverScaleTime).SetEase(ButtonHoverScaleCurve);
        // audioSource.PlayOneShot(onHoverSound);
        
    }

    public void OnHoverExitTween(Button button)
    {
        button.GetComponent<RectTransform>().DOScale(1,ButtonHoverScaleTime).SetEase(ButtonHoverScaleCurve);
        button.GetComponent<RectTransform>().DORotate(Vector3.zero, ButtonHoverScaleTime).SetEase(ButtonHoverScaleCurve);

    }
}
