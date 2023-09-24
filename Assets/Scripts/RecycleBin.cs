using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class RecycleBin : MonoBehaviour//, IDragHandler
{
    [SerializeField] private List<File> Files;
    private RectTransform Rect;

    [SerializeField] private AudioClip trashSound;
    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        Rect = GetComponent<RectTransform>();
    }

//     public void OnDrag(PointerEventData eventData)
//     {
//         Rect.anchoredPosition += eventData.delta;
//     }

    public void DeleteFileIfOverlapping(File file)
    {
        var fileWorldRect = new Rect(file.transform.position, file.Rect.rect.size);
        var binWorldRect = new Rect(this.transform.position, this.Rect.rect.size);
        var doesOverlap = binWorldRect.Overlaps(fileWorldRect);

        if (doesOverlap)
        {
            audioSource.PlayOneShot(trashSound);
            Files.Remove(file);
            Destroy(file.gameObject);
        }

        if (Files.Count == 0)
        {
            MinigameManager.Instance.MoveToNextScene();
        }
    }
}
