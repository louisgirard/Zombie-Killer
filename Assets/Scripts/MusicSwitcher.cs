using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitcher : MonoBehaviour
{
    [SerializeField] AudioClip music;
    MusicPlayer musicPlayer;

    private void Start()
    {
        musicPlayer = FindObjectOfType<MusicPlayer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            musicPlayer.SwitchMusic(music);
        }
        Destroy(gameObject);
    }
}
