using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabEnemies;
    private int[] enemiesToSpawn;
    public int enemiesPerWave;
    public int waves;
    public int wavesAmount;
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
        Debug.Log(enemiesToSpawn.Length + " googoddd");

        for (int i = 0; i < enemiesToSpawn.Length; i++)
        {

            Debug.Log(enemiesToSpawn[i] + " googo");
            while (enemiesToSpawn[i] > 0)
            {
                
                Instantiate(prefabEnemies[i], new Vector3(transform.position.x + Random.Range(-5, 5), transform.position.y, transform.position.z + Random.Range(-5, 5)), transform.rotation, enemyhandeler.transform);
                enemiesToSpawn[i]--;
                restock = true;
            }
        }
    }
}
