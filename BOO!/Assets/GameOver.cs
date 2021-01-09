using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPlayAgain;

    void OnMouseUp()
    {
        if(isPlayAgain)
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
