using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public static int EnemyCount = 0;
    public GameObject enemyPrefab;
    float[] lines = new float[] { -22f, -8f, 8f, 22f };
    public int maxEnemyCount = 5;
    [Range(0, 20)]
    public float enemySpawnDelay = 1.0f;
    private float enemySpawnTime;

    private void Start()
    {
        enemySpawnTime = enemySpawnDelay;
    }

    private void Update()
    {
        
            enemySpawnTime -= Time.deltaTime;

            if (Random.Range(0, 1000) % 13 == 0 && EnemyCount < maxEnemyCount && enemySpawnTime <= 0)
            {
            //Instantiate(enemyPrefab, new Vector3(lines[Random.Range(0, 3)], 0.3f, GetComponent<Transform>().position.z), Quaternion.identity);
                var e1 = Enem;
                EnemyCount++;
                enemySpawnTime = enemySpawnDelay;
                
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                
            }

            //Debug.Log(enemyList.Count);

        enemyList.RemoveAll(x => x == null);
    }
}
