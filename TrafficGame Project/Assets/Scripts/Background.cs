using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public GameObject background;
    GameObject tempBackground;
    Transform landscapeTransform;
    private int backgroundCount = 1;   

    // Start is called before the first frame update
    void Start()
    {
        landscapeTransform = background.transform.Find("Landscape").transform;
        backgroundCount = 1;
        background = Instantiate(background, new Vector3(0, 0, 0), background.transform.rotation);
         
    }

    // Update is called once per frame
    void Update()
    {

        if (backgroundCount < 2)
        {
            tempBackground = Instantiate(background, new Vector3(0, -0.1f,background.transform.position.z + landscapeTransform.lossyScale.y), background.transform.rotation);
            backgroundCount++;
        }
        background.transform.position -= new Vector3(0, 0, PlayerControl.SPEED);
        tempBackground.transform.position -= new Vector3(0, 0, PlayerControl.SPEED);
        tempBackground.name = "tempBackground";
        if (background.transform.position.z < -landscapeTransform.lossyScale.y)
        {
            Destroy(background);
            background = tempBackground;
            backgroundCount -= 1 ;
        }
    }
}
