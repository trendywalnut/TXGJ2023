using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupWindow : MonoBehaviour
{
    public void OnClose()
    {
        FindObjectOfType<PopupHandler>()?.RemovePopup(gameObject);
        Destroy(gameObject);
    }
}
