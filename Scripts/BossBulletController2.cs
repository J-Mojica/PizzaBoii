using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletController2 : MonoBehaviour {

    public float speed = 10f;
    public Rigidbody2D rb;
    public int damage = 20;


    // Start is called before the first frame update
    void Start() {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Movement movement = hitInfo.GetComponent<Movement>();
            
        if (movement != null)
        {
            movement.TakeDamage(damage);
            Destroy(gameObject);
        }
        else if (gameObject.transform.position.x > 200 || gameObject.transform.position.x < -200)
        {
            Destroy(gameObject);
        }
    }
}
