using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabEnemies;
<<<<<<< Updated upstream
    [SerializeField] private int[] enemiesToSpawn;
    [SerializeField] private int spawnTime;
=======
    private int[] enemiesToSpawn;
    [SerializeField] private int enemiesPerWave;
    public int waves;
>>>>>>> Stashed changes
    [SerializeField] private GameObject enemyhandeler;
    private bool restock = false;

    
    // Start is called before the first frame update
    void Start()
    {
        enemiesToSpawn = new int[prefabEnemies.Length];
        for (int i = 0; i < enemiesToSpawn.Length; i++)
        {
            enemiesToSpawn[i] = enemiesPerWave;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyhandeler.transform.childCount <= 0 && restock == true)
        {
            for (int i = 0; i < enemiesToSpawn.Length; i++)
            {
                enemiesToSpawn[i] = enemiesPerWave;
            }
            if (waves > 0)
            {
                waves--;
                enemySpawn();
            }
        }
    }
    public void enemySpawn()
    {
        for (int i = 0; i < enemiesToSpawn.Length; i++)
        {
            while (enemiesToSpawn[i] > 0)
            {
                Instantiate(prefabEnemies[i], new Vector3(transform.position.x + Random.Range(-3, 3), transform.position.y, transform.position.z + Random.Range(-3, 3)), transform.rotation, enemyhandeler.transform);
                enemiesToSpawn[i]--;
                restock = true;
            }
        }
    }
}
