using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LeaderBoards : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isBack;

    void OnMouseUp()
    {
        if(isBack)
        {
            SceneManager.LoadScene("MainMenu");
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
