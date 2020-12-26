using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //this veriable cotains the speed of the player
    [SerializeField]
    private float _speed = 3.8f;
    [SerializeField]
    private int _lives = 1;

    void CalculateMovement()
    {
      float horizontalInput = Input.GetAxis("Horizontal");
      //transform.Translate(Vector3.right * horizontalInput _speed Time.deltaTime);
      //vector3(0,0.68,0) * _speed * Time.deltaTime
      //transform.Translate (new Vector3(horizontalInput,0)*_speed * Time.deltaTime );
      Vector3 direction = new Vector3(horizontalInput,0);
      //(checking if horizontal or vertical) * _speed *  Time.deltaTime;
      transform.Translate(direction * _speed * Time.deltaTime);

      // if(transform.position.y >=0.68)
      // {
      //     //stop the player from going out of game space
      //     transform.position = new Vector3(transform.position.x,0,0);
      // }
      // //if the player's position is smaller or equal to 0.68f
      // else if(transform.position.y<= 0.68f)
      // {
      //   //stop the player from going lower than 0.68f
      //   transform.position = new Vector3(transform.position.x, 0.68f,0);
      // }
      //Vector3(transform.postion.x,MathF.Clamp(),0)
      transform.position = new Vector3(transform.position.x,Mathf.Clamp(transform.position.y,0.68f,0),0); 



      //check if the player went past 5.4f on the x axis
      if(transform.position.x > 5.4f)
      {
        // teleport the player to f on the axis
        transform.position = new Vector3 (0f,transform.position.y,0);
      }
      // check if the player went past 0f on the axis 
      else if(transform.position.x < 5.4)
      {

        //teleport the player to -5.4f on the axis
      transform.position = new Vector3(-5.4f,transform.position.y,0);
      }
    }
} 