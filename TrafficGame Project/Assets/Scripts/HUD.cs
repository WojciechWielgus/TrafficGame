using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text textSpeed;
    public Text textDistance;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        textSpeed.text = System.Math.Round(PlayerControl.SPEED * 15, 2) + " km/h";
        if(PlayerControl.DISTANCE < 10000) textDistance.text = System.Math.Round(PlayerControl.DISTANCE / 10, 0) + " m";
        else textDistance.text = System.Math.Round(PlayerControl.DISTANCE / 10000, 2) + " km";
        
    }
}
