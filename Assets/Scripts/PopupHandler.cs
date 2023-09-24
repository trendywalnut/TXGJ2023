using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupHandler : MonoBehaviour
{
    [SerializeField] private List<GameObject> Popups;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < Popups.Count; ++i)
        {
            //Popups[i].SetActive(false);
        }
    }

    public void RemovePopup(GameObject popup)
    {
        Popups.Remove(popup);

        if (Popups.Count == 0)
        {
            MinigameManager.Instance.MoveToNextScene();
        }
    }
}
