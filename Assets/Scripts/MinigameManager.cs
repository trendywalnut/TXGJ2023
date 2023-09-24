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
}
