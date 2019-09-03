using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float[] lines = new float[] { -22f, -8f, 8f, 22f };
    GameObject prefab;
    GameObject enemy;
    Transform enemyTransform;

    void Start()
    {
        enemy = Instantiate(prefab, new Vector3(lines[2], 0.3f, 200f), Quaternion.identity);
        enemyTransform = enemy.transform;
    }


    // Update is called once per frame
    void Update()
    {
        enemyTransform.position -= new Vector3(0, 0,  (PlayerControl.SPEED * Time.deltaTime) + 2f);
        //Debug.Log(PlayerControl.SPEED);

        //if (TransformEnemy.position.z < -200) Destroy(this.gameObject);
    }

    public Enemy(GameObject prefab)
    {
        this.prefab = prefab;
        
        
    }
}
