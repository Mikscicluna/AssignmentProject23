using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Instructions : MonoBehaviour
{
    public bool isBack;

    // Start is called before the first frame update
    void OnMouseUp()
    {
        if(isBack)
        {
            SceneManager.LoadScene("Options");
        }
    }
}
