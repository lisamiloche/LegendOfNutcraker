using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject spellPrefab;
    public GameObject Enemy;
    public GameObject player;
    public int playerLife;
    public int _maxLife;
    public int rangeShoot;
    public float timerDamage;
    public float cooldownDamage;
    public bool isOkayToScroll;
    Enemies enemies;
    private MainGame mainGame;
    int _timeRecovery = 0;
    float _timeShoot = 1000;

    private void Start()
    {
        mainGame = FindFirstObjectByType<MainGame>();
        _maxLife = (int)mainGame.PowerUps[1].Value;
        playerLife = _maxLife;
        _timeShoot /= mainGame.PowerUps[3].Value;
    }

    private void Update()
    {
        ShootNearestEnemy();
        _maxLife = (int)mainGame.PowerUps[1].Value;
        if (playerLife < _maxLife )
        {
            Recovery();
        }
        else playerLife = _maxLife;
    }

    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.name == "Enemy")
        {
            Enemies enemies = col.GetComponent<Enemies>();

            if (timerDamage > 0)
            {
                timerDamage -= Time.deltaTime;
                //Debug.Log(timerDamage);
            }

            if (timerDamage <= 0)
            {
                playerLife -= enemies.enemyDamage;
                Debug.Log(playerLife);

                if (playerLife <= 0)
                {
                    Destroy(player); //animation de mort
                }
                timerDamage = cooldownDamage;
            }


            if (enemies != null)
            {
                enemies.HandleCollision();
            }
        }
    }

    void ShootNearestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");


        if (enemies.Length > 0)
        {
            GameObject nearestEnemy = null;
            float nearestDistance = Mathf.Infinity;

            foreach (GameObject enemy in enemies)
            {
                float distance = Vector2.Distance(transform.position, enemy.transform.position);

                if (distance < nearestDistance)
                {
                    nearestDistance = distance;
                    nearestEnemy = enemy;
                }

            }

            if (nearestDistance <= rangeShoot)
            {
                if (GameObject.FindWithTag("Spell") == null)
                { 
                        Vector3 spawnSpell = transform.position;

                        GameObject spell = Instantiate(spellPrefab, transform.position, Quaternion.identity);
                        Enemy = nearestEnemy;
                        
                }

            }


        }

        /*if (GameObject.FindWithTag("Spell") == null)
        {
            isOkayToScroll = true;
        }
        else
        {
            isOkayToScroll = false;
        }*/

    }

    public void Recovery()
    {
        
        if (_timeRecovery == 1000)
        {
            playerLife += (int)mainGame.PowerUps[2].Value;
            _timeRecovery = 0;
        }
        else _timeRecovery++;

     
    }
}



