using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    public float speed;
 
    void Update()
    {
        transform.Rotate(new Vector3(0, 40, 0) * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);

    }
}
