using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class BulletMaker : MonoBehaviour
{
    public GameObject projectile;
    public Transform fire;

    public float shootTimer;
    public float shootRate = .5f;

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Mouse0)) {
            if(shootTimer < 0)
            {
                GameObject bullet = Instantiate(projectile, fire.position, Quaternion.identity) as GameObject;
                shootTimer = shootRate;
            }
            else
            {
                shootTimer -= Time.deltaTime;
            }
        } 
        
    }
    

}
