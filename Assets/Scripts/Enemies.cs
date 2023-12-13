using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed;
    public int enemyLife;
    public int enemyDamage;
    public GameObject Enemy;
    public float MoneyEarn;
    private bool isCollided = false;
    public GameObject _Script;
    private EnemySpawner spawner;

    private void Start()
    {
        spawner = FindFirstObjectByType<EnemySpawner>();
    }


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
            _Script.GetComponent<MainGame>().Money += MoneyEarn;
            spawner.enemiesAlive--;

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