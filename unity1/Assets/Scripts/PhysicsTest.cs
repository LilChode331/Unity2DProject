using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("Collision");
        Debug.Log("Collision with: " + collision.gameObject.name);
        Destroy(gameObject);
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        Debug.Log("Triggerd: " + collision.gameObject.name);
    }
}
