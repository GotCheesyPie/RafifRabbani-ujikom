using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMobs : MonoBehaviour
{
    public List<GameObject> mobPrefabs = new List<GameObject>();
    public Transform first;
    public Transform last;
    public void Spawn()
    {
        int mobIndex = Random.Range(0, mobPrefabs.Count-1);
        float randX = Random.Range(first.position.x, last.position.x);
        Vector3 spawnPoint = new Vector3(randX, first.position.y, first.position.z);
        Instantiate(mobPrefabs[mobIndex], spawnPoint, first.rotation);
    }
    IEnumerator SpawnWithDelay()
    {
        while(true)
        {
            Spawn();
            yield return new WaitForSeconds(Random.Range(1, 3));
        }
    }

    void Start()
    {
        StartCoroutine(SpawnWithDelay());
    }
}
