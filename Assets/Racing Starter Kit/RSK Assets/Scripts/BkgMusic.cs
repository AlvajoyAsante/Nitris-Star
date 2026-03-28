using UnityEngine;

// Created by Ayemhenre Isikhuemhen
public class BkgMusic : MonoBehaviour
{
    public AudioClip menuMusic;
    public AudioClip raceMusic;

    private AudioSource audioSource;

    // temporary solution to have music persist between scenes, will be replaced with a more robust music manager in the future
    void Start()
    {
    audioSource = GetComponent<AudioSource>();
    audioSource.clip = raceMusic;
    audioSource.loop = true;
    audioSource.Play();
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject); // persists between scenes
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMenu()
    {
        audioSource.clip = menuMusic;
        audioSource.Play();
    }

    public void PlayRace()
    {
        audioSource.clip = raceMusic;
        audioSource.Play();
    }

}