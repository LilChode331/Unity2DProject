using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResawnPlayer : MonoBehaviour
{
    float lives = 3;
    public float threshold;
private void FixedUpdate() 
{
    
    
    if(transform.position.y < threshold)
    {
        transform.position = new Vector3(1f,4f,0f);
        lives--;
    }
    if(lives <= 0)
    {
        SceneManager.LoadScene("LoseScence");
    }
    
}
}
