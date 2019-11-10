using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;
    public Sprite[] toppings;
    public RuntimeAnimatorController[] animations;

    public int t1Index = 0;
    public int t2Index = 0;



    private void Awake()
    {
        if (inst)
        {
            Destroy(this);
        }
        else
        {
            inst = this;
            DontDestroyOnLoad(this);
        }
    }



}
