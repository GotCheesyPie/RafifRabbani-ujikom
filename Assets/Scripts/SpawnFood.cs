using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject foodPrefab;
    public AudioClip sfx;
    public void Spawn()
    {
        Instantiate(foodPrefab, transform.position + Vector3.forward + Vector3.up, transform.rotation);
        PlayAudioAtCamera.Play(sfx);
    }
}
