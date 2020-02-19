using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public Transform spawnPoint;//Add empty gameobject as spawnPoint
    public float deathHeight = -20.0f;

    void FixedUpdate()
    {
        if (transform.position.y < deathHeight)
        {
            transform.position = spawnPoint.position;
        }
            
    }

}
