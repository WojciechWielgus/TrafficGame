using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    Text textPlatButton;
    
    void Start()
    {
        textPlatButton = GetComponent<Text>();
    }

    public void hover()
    {
        textPlatButton.color = Color.blue;
    }

    public void unhover()
    {
        textPlatButton.color = Color.white;
    }

    public void zmienMenu()
    {
        SceneManager.LoadScene(1);
    }

    
}
