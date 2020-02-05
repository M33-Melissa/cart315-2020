using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColorRamdomizer : MonoBehaviour
{
    private Renderer renderer;
    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    void Start()
    {
        float r = Random.Range(0, 255)/255f;
        float g = Random.Range(0, 255)/255f;
        float b = Random.Range(0, 255)/255f;
        renderer.material.color = new Color(r,g,b);
    }
}
