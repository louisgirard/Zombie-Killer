using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;
    float fadeOutSpeed = 0.1f;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();   
    }

    public void SwitchMusic(AudioClip music)
    {
        StartCoroutine(FadeOut(music));
    }

    private IEnumerator FadeOut(AudioClip music)
    {
        while (audioSource.volume > 0)
        {
            audioSource.volume -= fadeOutSpeed;
            yield return new WaitForSeconds(0.1f);
        }
        ChangeMusic(music);
    }

    private void ChangeMusic(AudioClip music)
    {
        audioSource.clip = music;
        audioSource.volume = 1;
        audioSource.Play();
    }
}
