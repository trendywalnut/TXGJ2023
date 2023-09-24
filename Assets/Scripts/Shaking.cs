using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaking : MonoBehaviour
{

    [SerializeField]
    float speedX = 5;
    [SerializeField]
    float speedY = 5;
    [SerializeField]
    float amplitude = 5;


    Vector2 startingPos;

    void Awake()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //floating point errors later :) but its a game jam 
        float x = startingPos.x + Mathf.Sin(Time.time * speedX) * amplitude;
        float y = startingPos.y + (Mathf.Sin(Time.time * speedY) * amplitude);

        transform.position = new Vector2(x, y);
    }
}
