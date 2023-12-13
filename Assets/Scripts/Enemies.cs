using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Networking.PlayerConnection;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed;
    public int enemyLife;
    public int enemyDamage;
    public GameObject Enemy;
    public int MoneyEarn;
    private bool isCollided = false;

    void Update()
    {

        if (!isCollided)
        {
            MoveEnemy();
        }


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


    public void HandleCollision()
    {
        speed = 0;
    }


        public void MoveEnemy()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    
} 