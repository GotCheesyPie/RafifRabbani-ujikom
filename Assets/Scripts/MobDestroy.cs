using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MobDestroy : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);        
    }
}
