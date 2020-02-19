using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushbutton : MonoBehaviour
{
    public float distance = 1.16f;

    void Start()
    {

    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            //transform.position = new Vector3(-2.46f, 5.55f - distance, 4.95f);
        }
    }
}
