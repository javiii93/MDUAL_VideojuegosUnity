﻿using UnityEngine;
using
System.Collections;
public class PlayerBulletController : MonoBehaviour
{
    //Se li assignara un objecte automaticament, en crear una bala a PlayerStateListener
    public GameObject
    playerObject = null; 
    public float bulletSpeed = 15.0f;
    public void launchBullet()
    { // Volem que el Player dispari cap al costat al que mira.
// Aixo ens ho indica el component "local scale" ha de ser trigger
    
    float mainXScale = playerObject.transform.localScale.x;
        Vector2 bulletForce;
        if (mainXScale < 0.0f)
        {
            // Disparar cap a l'esquerra
            bulletForce = new Vector2(bulletSpeed * -1.0f, 0.0f);
        }
        else
        {
            // Disparar cap a la dreta
            bulletForce = new Vector2(bulletSpeed, 0.0f);
        }
        GetComponent<Rigidbody2D>().velocity = bulletForce;
    }
}