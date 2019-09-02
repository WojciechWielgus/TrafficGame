using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform transform;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0,  (PlayerControl.SPEED * Time.deltaTime) + 2f);

        Debug.Log(PlayerControl.SPEED);
    }

   
}
