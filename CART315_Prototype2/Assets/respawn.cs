using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public Transform spawnPoint;//Add empty gameobject as spawnPoint
    public float deathHeight = -20.0f;
    public GameObject player; //Add your player

    void Update()
    {
        if (player.transform.position.y < deathHeight)
            player.transform.position = spawnPoint.position;
    }

}
