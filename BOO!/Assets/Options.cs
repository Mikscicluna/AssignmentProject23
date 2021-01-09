﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Options : MonoBehaviour
{
    public bool isBack;
    public bool isVisuals;

    public bool isAudio;

    // Start is called before the first frame update
    void OnMouseUp()
    {
        if(isBack)
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (isVisuals)
        {
            SceneManager.LoadScene("Visuals");
        }
        if (isAudio)
        {
            SceneManager.LoadScene("Audio");
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
