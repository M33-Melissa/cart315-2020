using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushbutton : MonoBehaviour
{
    public BallSpawner spawner = null;
    private Animator animator = null;
    private bool isColliding = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = false;
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && isColliding)
        {
            animator.SetTrigger("Press");
            //spawn balls
            Renderer renderer = GetComponent<Renderer>();
            spawner.SpawnBalls(renderer.material.color);
        }
    }
}
