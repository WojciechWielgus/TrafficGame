using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public GameObject background;
    private int backgroundCount = 1;
    private 
   

    // Start is called before the first frame update
    void Start()
    {
        background = Instantiate(background, new Vector3(0, 0, 0), background.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {


        background.transform.position -= new Vector3(0, 0, PlayerControl.SPEED);
        if (background.transform.position.z < -200)
        {

            background.transform.position += new Vector3(0, 0, 200);
        }
        if()

    }
}
