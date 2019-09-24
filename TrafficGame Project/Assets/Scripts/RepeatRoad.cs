using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatRoad : MonoBehaviour
{
    /*
    float offset;
    float tempOffset;


    public GameObject BackgroundPrefab;
    Vector3 BackgroundCreateCoortinates = new Vector3(0, -0.1f, 200);
    private GameObject Background;
    private int backgroundCount = 1;
    

    void Start()
    {
        Background = Instantiate(BackgroundPrefab, new Vector3(0, -0.1f, 200), BackgroundPrefab.transform.rotation);
    }

    void Update()
    {
        offset = PlayerControl.DISTANCE * 0.001f; 
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, offset);
        
        
        

        
        //Background.transform.position -= new Vector3(0, 0, PlayerControl.SPEED * Time.deltaTime * 0.45f);
        Background.transform.position -= new Vector3(0, 0, (offset - tempOffset) * 1000);
        if (Background.transform.position.z < -100 && backgroundCount < 2)
        {
            Background.transform.position += new Vector3(0, 0, 300);
        }
        


        //Debug.Log(PlayerControl.DISTANCE * 0.001f);
        Debug.Log(PlayerControl.SPEED);
        Debug.Log("tempOffset " + ((offset-tempOffset)*1000));
        tempOffset = offset;
    }
    */
}
