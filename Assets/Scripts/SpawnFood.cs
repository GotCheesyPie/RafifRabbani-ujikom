using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject foodPrefab;
    public void Spawn()
    {
        Instantiate(foodPrefab, transform.position + Vector3.forward, transform.rotation);
    }
}
