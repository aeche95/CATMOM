using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{

    [SerializeField]
    AudioManagerSO data;

    [SerializeField]
    AudioSource bgMusicAudioSource;


    // Start is called before the first frame update
    void Start()
    {
        SceneManager.sceneLoaded += ResumeMusic;
        SceneManager.sceneUnloaded += PauseMusic;
        bgMusicAudioSource.clip = data.bgMusic;
        bgMusicAudioSource.volume = data.volume;
        bgMusicAudioSource.Play();
    }

    private void PauseMusic(Scene arg0)
    {
        bgMusicAudioSource.Pause();
    }

    private void ResumeMusic(Scene arg0, LoadSceneMode arg1)
    {
     
        bgMusicAudioSource.UnPause();
    }

    public void SetNewClip(AudioClip newClip)
    {
        bgMusicAudioSource.clip = newClip;
    }

}
