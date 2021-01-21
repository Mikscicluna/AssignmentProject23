using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public bool isPause;
    public bool isResume;

    void OnMouseUp()
    {
        if(isPause) //pause button sets timescale to 0 when pressed 
        {
            GameIsPaused = true;
            Time.timeScale = 0f;
        }
        if(isResume); //sets timescale to 1 when pressed
        {
            GameIsPaused = false;
            Time.timeScale = 1f;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
