using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject spellPrefab;
    public GameObject Enemy;
    public GameObject player;
    public int playerLife;
    public int rangeShoot;
    public float timerDamage;
    public float cooldownDamage;


    private void Update()
    {
        ShootNearestEnemy();
    }

    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.name == "Enemy")
        {
            Enemies enemies = col.GetComponent<Enemies>();

            

            if (timerDamage > 0)
            {
                timerDamage -= Time.deltaTime;
                Debug.Log(timerDamage);
            }

            if (timerDamage <= 0)
            { 
                playerLife--;
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


    }

}

