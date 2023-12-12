using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed;
    public int enemyLife;
    public int enemyDamage;
    public GameObject Enemy;
    MainGame MainGame;
    public int MoneyEarn;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        Died();
    }

    public void Died()
    {
        if (enemyLife <= 0)
        {
            Destroy(Enemy);
            //MainGame.Money += MoneyEarn; //pb avec cette ligne
        }
    }
}