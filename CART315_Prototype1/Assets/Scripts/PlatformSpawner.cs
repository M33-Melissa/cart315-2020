using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform = null;
    public Transform spawnerParent = null;
    public Transform spawnerTransform = null;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(platform, spawnerTransform.position, Quaternion.identity, spawnerParent);
        }
    }
}