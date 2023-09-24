using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupHandler : MonoBehaviour
{
    [SerializeField] private List<GameObject> Popups;

    // Start is called before the first frame update
    void Start()
    {
        MinigameManager.Instance.SetPlay(false);
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
