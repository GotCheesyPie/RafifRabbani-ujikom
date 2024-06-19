using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerManager : MonoBehaviour
{
    public int hungerNeed;
    public int currentHunger = 0;
    public int givenScore;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided");
        Debug.Log(collision.collider.name);
        if(collision.gameObject.tag == "Food")
        {
            currentHunger += 25;
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        if(currentHunger >= hungerNeed)
        {
            FindAnyObjectByType<ScoreManager>().score += givenScore;
            Destroy(gameObject);
        }
    }
}
