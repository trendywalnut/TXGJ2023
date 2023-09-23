using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameManager : MonoBehaviour
{
    public static MinigameManager Instance;

    [SerializeField] 
    [Tooltip("Order minigames will be played in. Elements are the Build Index of each scene. Will advance automatically by calling MoveToNextScene() from a minigame.")]
    private int[] MinigameScenesIndices;
    private int CurrentSceneIndex = -1;

    private AudioSource Audio;

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
        CurrentSceneIndex++;
        if(CurrentSceneIndex >= 0 && CurrentSceneIndex < MinigameScenesIndices.Length)
        {
            Debug.Log("Loading Scene " + MinigameScenesIndices[CurrentSceneIndex]);
            SceneManager.LoadScene(MinigameScenesIndices[CurrentSceneIndex]);
        }
    }
}
