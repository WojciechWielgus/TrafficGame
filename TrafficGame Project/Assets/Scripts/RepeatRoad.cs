using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatRoad : MonoBehaviour
{
    Vector2 offset;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        offset = new Vector2(0, PlayerControl.DISTANCE / 1000);
        GetComponent<Renderer>().material.mainTextureOffset = offset;

       
    }
}
