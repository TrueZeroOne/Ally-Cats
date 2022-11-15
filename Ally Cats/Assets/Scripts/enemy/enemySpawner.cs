using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabEnemies;
    [SerializeField] private int[] enemiesToSpawn;
    [SerializeField] private int spawnTime;
    [SerializeField] private GameObject enemyhandeler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < enemiesToSpawn.Length; i++)
        {
            while(enemiesToSpawn[i] > 0)
            {
                Instantiate(prefabEnemies[i], new Vector3(Random.Range(-10,10),transform.position.y,Random.Range(-10,10)), transform.rotation,enemyhandeler.transform);
                enemiesToSpawn[i]--;
            }
        }
        if (enemyhandeler.transform.childCount <= 0)
        {
            for (int i = 0; i < enemiesToSpawn.Length; i++)
            {
                enemiesToSpawn[i] = 2;
            }
        }
    }
}
