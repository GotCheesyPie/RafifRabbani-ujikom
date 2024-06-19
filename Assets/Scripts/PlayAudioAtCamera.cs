using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayAudioAtCamera
{
    public static void Play(AudioClip sfx)
    {
        Camera.main.GetComponent<AudioSource>().PlayOneShot(sfx);
    }
}
