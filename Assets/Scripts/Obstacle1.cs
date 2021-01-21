using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //create  a veriable for the speed of the enemy 
    [SerializeField]
    private float _speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transalte the enemy postion down
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        // the enemy postions has gone below -11.9 on the z axis
        if(transform.position.z < -11.9f)
        {
            //respawn enemy at random point on x axis from top of screen
            //vector3 teleport = new vector3(transfrom.postion.z,7.5f,9.5)
            float randomX = Random.Range(-7.5f,7.1f);
            transform.position = new Vector3(Random.Range(-7.5f,7.1f),9.5f,0);
        }
        // change the postion to teleport enemy back to the top of the screen 9.5f on the z axis
        
    }

}
