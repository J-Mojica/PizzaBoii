using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed = 10f;
    public Rigidbody2D rb;
    public CircleCollider2D cCollider;
    private bool fliped = false;
    public int damage = 10;
    // Start is called before the first frame update
    void Start() {
        if (CharacterController2D.m_FacingRight) {
            rb.velocity = transform.right * speed;
            if (fliped)
            {
                Vector3 scale = transform.localScale;
                scale *= -1;
                transform.localScale = scale;
            }
            
        } else {
            rb.velocity = -transform.right * speed;
            if (!fliped)
            {
                Vector3 scale = transform.localScale;
                scale *= -1;
                transform.localScale = scale;
            }
            
        }

    }
    void OnTriggerEnter2D(Collider2D hitInfo) {
        LeftHand hand = hitInfo.GetComponent<LeftHand>();

        if (hand != null)
        {
            hand.TakeDamage(damage);
            Destroy(gameObject);
        }
        else if (gameObject.transform.position.x > 200 || gameObject.transform.position.x < -200)
        {
            Destroy(gameObject);
        }


    }
}
