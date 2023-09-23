using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditor;
using UnityEngine.UIElements;

public class SelectableTopPanel : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    [SerializeField] private Transform parentTransform;
    private bool selected;

    private void Awake() {
        parentTransform = transform.parent;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log(gameObject.name + " was pressed");
        selected = true;
    }

    
    public void OnPointerUp(PointerEventData eventData)
    {
        selected = false;
    }

    private void Update() 
    {
        if (selected)
        {
            parentTransform.position = Input.mousePosition;
        }
    }
}

    

