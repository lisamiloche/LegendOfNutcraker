using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    public int baseEnemies; // nombre d'ennemis qui apparaissent
    public float enemiesPerSecond; // nb d'ennemis par seconde
    public GameObject[] enemyPrefab; // "liste" pour les ennemis
    public float timerForBoss; // timer pour la durée du boss
    public float difficultyScalingFactor; // indice de progression (nombre ennemis/waves)
    public float timeBeforeRespawn;
    public GameObject Enemy;

    public int currentLvl; // nb lvl
    public int currentWave; // nb wave
    public TMP_Text Level;

    private float timeSinceLastSpawn;
    public int enemiesAlive; // nombre d'ennemis en  vie
    private int enemiesLeftToSpawn; //nombre d'ennemis qu'il reste à spawn
    private bool isSpawning = false; // est-ce que les ennemis sont entrain de spawn ?
    public bool isBossDead = false;

    private void Start()
    {
        StartWave();
    }

    private void Update()
    {
        if (!isSpawning) return;

        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= (1f / enemiesPerSecond) && enemiesLeftToSpawn > 0)
        {
            if (currentWave == 4)
            {
                SpawnerBoss();
            }
            else
            {
                Spawner();
            }
            
            enemiesLeftToSpawn--;
            enemiesAlive++;
            //Debug.Log(enemiesAlive);
            timeSinceLastSpawn = 0f;
        }

        if (enemiesAlive == 0 && enemiesLeftToSpawn == 0)
        {
            EndWave();
        }

        Level.text = "Lv " + currentLvl + "." + currentWave;

    }

    void StartWave()
    {
        isSpawning = true;
        enemiesLeftToSpawn = EnemiesPerWave();
        if (currentWave == 4)
        {
            enemiesLeftToSpawn = 1;
        }
    }

    private int EnemiesPerWave()
    {
        return Mathf.RoundToInt(baseEnemies * Mathf.Pow(currentWave, difficultyScalingFactor));
    }

    void Spawner()
    {
        GameObject prefabToSpwan = enemyPrefab[0];
        Instantiate(prefabToSpwan, transform.position, Quaternion.identity);
    }

    void SpawnerBoss()
    {
        GameObject prefabToSpwan = enemyPrefab[1];
        Instantiate(prefabToSpwan, transform.position, Quaternion.identity);
    }

    void EndWave()
    {
        isSpawning = false;
        timeSinceLastSpawn = 0f;
        int lastWave = currentWave;
        if (lastWave == 4)
        {
            isBossDead = true;
            currentWave = 1;
            currentLvl++;
        }
        else
        {
            isBossDead = false;
            currentWave++;
        }
        //Debug.Log(currentLvl);
        StartWave();
        
    }

}
