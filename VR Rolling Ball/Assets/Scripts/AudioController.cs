using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip[] clips;
    AudioSource soundFX;

    private void Start()
    {
        soundFX = GetComponent<AudioSource>();
    }

    public void PlayAudio(int clipIndex)
    {
        AudioClip clip = clips[clipIndex];
        if(clip != null)
        {
            soundFX.clip = clip;
            soundFX.Play();
        }
    }
}
