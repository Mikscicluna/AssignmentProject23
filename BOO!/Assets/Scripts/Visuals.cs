using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Visuals : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isBack;

    void OnMouseUp()
    {
        if(isBack)
        {
            SceneManager.LoadScene("Options");
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
