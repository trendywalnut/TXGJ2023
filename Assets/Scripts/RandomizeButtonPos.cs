using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomizeButtonPos : MonoBehaviour
{
    [SerializeField] Button thisButton;

    private float xPos;
    private float yPos;
    private RectTransform rectTransform;

    void Start()
    {
        //thisButton = GetComponent<Button>();
        RectTransform rectTransform = GetComponent<RectTransform>();

        thisButton.onClick.AddListener(() =>
        {
            xPos = Random.Range(-325, 325);
            yPos = Random.Range(-180, 80);

            rectTransform.localPosition = new Vector2(xPos, yPos);
            //transform.position = new Vector2(xPos, yPos);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
