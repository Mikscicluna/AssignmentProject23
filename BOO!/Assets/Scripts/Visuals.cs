using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Visuals : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isBack;
    public bool isFullscreen;

    void OnMouseUp()
    {
        if(isBack)
        {
            SceneManager.LoadScene("Options");
        }
    }
    
    //Fullscreen toggle to change between fullscreen and windowed
    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        Debug.Log("Changing Screen Settings"); //to check if it is working
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
