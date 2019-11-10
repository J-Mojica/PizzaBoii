using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public GameObject leftHand;
    public GameObject rightHand;
    public bool swi = true;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update() {
        Debug.Log((int)Time.time);
        if (swi) {
            leftHand.transform.Translate(0, Time.deltaTime, 0, Space.World);
            rightHand.transform.Translate(0, -Time.deltaTime, 0, Space.World);
        } else {
            leftHand.transform.Translate(0, -Time.deltaTime, 0, Space.World);
            rightHand.transform.Translate(0, Time.deltaTime, 0, Space.World);
        }
        if ((int)Time.time % 3 == 0)
        {
            swi = !swi;
        }

    }
}
