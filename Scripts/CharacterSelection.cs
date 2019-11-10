using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{

    public Sprite[] toppings;
    public Image toppings1, toppings2;
    public int t1Index = 0;
    public int t2Index = 0;


    private void Awake()
    {
        if(GameManager.inst)
        GameManager.inst.toppings = toppings;


        toppings1.sprite = toppings[t1Index];
        toppings2.sprite = toppings[t2Index];
    }
    public void ChangeTopping1Left()
    {
        if (t1Index > 0)
            t1Index--;
        else
            t1Index = toppings.Length-1;
        toppings1.sprite = toppings[t1Index];


        GameManager.inst.t1Index = t1Index;
    }
    public void ChangeTopping1Right()
    {
        if (t1Index < toppings.Length-1)
            t1Index++;
        else
            t1Index = 0;
        toppings1.sprite = toppings[t1Index];


        GameManager.inst.t1Index = t1Index;
    }

    public void Select()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ChangeTopping2Right()
    {
        if (t2Index < toppings.Length-1)
            t2Index++;
        else
            t2Index = 0;
        toppings2.sprite = toppings[t2Index];


        GameManager.inst.t2Index = t2Index;
    }
    public void ChangeTopping2Left()
    {
        if (t2Index > 0)
            t2Index--;
        else
            t2Index = toppings.Length-1;
        toppings2.sprite = toppings[t2Index];


        GameManager.inst.t2Index = t2Index;
    }

}
