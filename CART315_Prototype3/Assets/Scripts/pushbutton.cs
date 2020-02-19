using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushbutton : MonoBehaviour
{
    Vector3 position;
    void Start()
    {

    }

    private void OnMouseEnter()
    {
        position = this.transform.position;
        position.x = -1.16f;
    }
}
