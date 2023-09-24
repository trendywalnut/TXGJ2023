using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LoadCrank : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] GameObject LoadCrankRotatePoint;
    [SerializeField] Slider ProgressBar;
    [SerializeField] public int  ProgressMin = 0;
    [SerializeField] public int ProgressMax = 100;
    [SerializeField] public int AmountPerCrank = 20;

    private bool Dragging;
    private bool FullPosRotation;
    private bool FullNegRotation;
    private float LastAngle = 0.0f;
    private int fullRotations;

    private void Start()
    {
        ProgressBar.minValue = ProgressMin;
        ProgressBar.maxValue = ProgressMax;
        ProgressBar.value = ProgressMin;
    }

    public void OnBeginDrag(PointerEventData data)
    {
        Dragging = true;
    }

    public void OnEndDrag(PointerEventData data)
    {
        Dragging = false;
    }

    public void OnDrag(PointerEventData data)
    {
        Vector3 dir = Input.mousePosition - LoadCrankRotatePoint.transform.position;
        float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg) - 90.0f;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        LoadCrankRotatePoint.transform.rotation = Quaternion.RotateTowards(LoadCrankRotatePoint.transform.rotation, q, 1);
        if(LastAngle - angle > 270)
        {
            FullPosRotation = false;
            FullNegRotation = true;
        }
        else if(angle - LastAngle > 270)
        {
            FullPosRotation = true;
            FullNegRotation = false;
        }
        else
        {
            FullPosRotation = false;
            FullNegRotation = false;    
        }
        LastAngle = angle;
    }

    private void Update()
    {
        if(Dragging && FullPosRotation)
        {
            ProgressBar.value += AmountPerCrank;
        }   
        else if(Dragging && FullNegRotation)
        {
            ProgressBar.value -= AmountPerCrank;
        }
        FullPosRotation = false;
        FullNegRotation = false;
        
        if(ProgressBar.value >= ProgressMax)
        {
            MinigameManager.Instance.MoveToNextScene();
        } 
    }
}
