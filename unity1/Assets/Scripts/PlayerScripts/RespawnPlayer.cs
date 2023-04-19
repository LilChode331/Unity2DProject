using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnPlayer : MonoBehaviour
{
    Projectile projectile;
    DeathBox deathBox;
    float lives = 3;
    public float threshold;

    private void Awake()
    {
        projectile = GameObject.FindGameObjectWithTag("Projectile").GetComponent<Projectile>();
        deathBox = GameObject.FindGameObjectWithTag("DeathBox").GetComponent<DeathBox>();
    }   

    private void FixedUpdate() 
    {
        if(transform.position.y < threshold || projectile.playerHit == true || deathBox.boxHit == true )
        {
            transform.position = new Vector3(16f,4f,0f);
            lives--;
            projectile.playerHit = false;
            deathBox.boxHit = false;
            SoundManager.instance.PlaySound(1);
        }
        
        if(lives <= 0)
        {
            StartCoroutine(LoadSceneAfterDelay("LoseScence", 3f));
        }
    }
    
    private IEnumerator LoadSceneAfterDelay(string sceneName, float delaySeconds)
    {
        yield return new WaitForSeconds(delaySeconds);
        SceneManager.LoadScene(sceneName);
    }
}
