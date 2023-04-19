using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject SplosionPrefab_0;
    public bool playerHit = false;
    
    // ...
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.transform.tag == "Player")
        {
            Instantiate(SplosionPrefab_0, transform.position, Quaternion.identity);
            Destroy(gameObject);
            playerHit = true;
        }

    }
} 
    



