using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Leaderboard: MonoBehaviour
{
    public bool isBack;

    // Start is called before the first frame update
    void OnMouseUp()
    {
        if(isBack)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
