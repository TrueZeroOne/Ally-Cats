using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabEnemies;
    [SerializeField] private int[] enemiesToSpawn;
    [SerializeField] private int spawnTime;
    private System.DateTime startTime;
    private bool canSpawn = true;
    // Start is called before the first frame update
    void Start()
    {
        startTime = DateTime.Now;
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan ts = DateTime.Now-startTime;
        if (ts.Seconds > spawnTime)
        {
            startTime = DateTime.Now;
            int allEmpty = 0;
            int spawnEnemy = UnityEngine.Random.Range(0, enemiesToSpawn.Length);
            if (enemiesToSpawn[spawnEnemy] > 0 && canSpawn)
            {
                enemiesToSpawn[spawnEnemy]--;
                Instantiate(prefabEnemies[spawnEnemy]);
            }
            for (int i = 0; i < enemiesToSpawn.Length; i++)
            {
                if (enemiesToSpawn[i] < 1)
                {
                    allEmpty++;
                }

                if (allEmpty == enemiesToSpawn.Length) { canSpawn = false; } else { allEmpty = 0; }
            }
        }
    }
}
