using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoContinue : MonoBehaviour
{
    public VideoPlayer player;

    private void Start() 
    {
        player = GetComponent<VideoPlayer>();
        player.loopPointReached += EndReached;    
    }

    private void EndReached(VideoPlayer source)
    {
        MinigameManager.Instance.MoveToNextScene();
        Debug.Log("Video Ended.");
    }
}
