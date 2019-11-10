using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullets : MonoBehaviour
{
    public GameObject bossProjectile;
    public float shootTimer;
    public float shootRate = .5f;
    public Transform hand;
    public static int modifier;


    // Update is called once per frame
    void FixedUpdate()
    {
            if (shootTimer < 0)
            {
           
                GameObject bossBullet = Instantiate(bossProjectile, hand.position, Quaternion.identity) as GameObject;
                shootTimer = shootRate;
            }
            else
            {
                shootTimer -= Time.deltaTime;
            }
        
    }
}
