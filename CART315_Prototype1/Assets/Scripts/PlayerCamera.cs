using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;
    Vector3 offset;
    
    private void Awake()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
