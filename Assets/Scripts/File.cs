using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class File : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public RectTransform Rect => _rect;
    private RectTransform _rect;

    private void Awake()
    {
        _rect = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Rect.transform.position += new Vector3(eventData.delta.x, eventData.delta.y, 0.0f);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        var recycleBin = FindObjectOfType<RecycleBin>();
        recycleBin.DeleteFileIfOverlapping(this);
    }
}
