using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class MinigameManager : MonoBehaviour
{
    public static MinigameManager Instance;

    private AudioSource Audio;

    public Stopwatch Timer;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        Audio = GetComponent<AudioSource>();
        if(!Audio.isPlaying)
        {
            Audio.Play();
        }
    }

    // Called from each mini game to advance to the next
    public void MoveToNextScene()
    {
        if(Timer == null)
        {
            Timer = new Stopwatch();
        }

        if(!Timer.IsRunning)
        {
            
            Timer.Reset();
            Timer.Start();
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void UpdateVolume(float value)
    {
        var mixerValue = (value == 0) ? -80f : Mathf.Lerp(-20f, 0f, value * 0.01f);
        Audio.outputAudioMixerGroup.audioMixer.SetFloat("MasterVolume", mixerValue);
    }

    public void SetPlay(bool play)
    {
        if (play && !Audio.isPlaying) Audio.Play();
        else Audio.Stop();
    }
}
