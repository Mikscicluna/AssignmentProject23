using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ghost : MonoBehaviour
{
    private Vector2 direction;
    Rigidbody rb;
    public float speed;
    public float dirY, dirZ;
//Use below for initialization
    void Start() {
      rb = GetComponent<Rigidbody>();
    }
    //Update is called once per frame
    void Update() {
      speed = 7f;
      if(Input.GetAxis("Horizontal")<0){
        direction = Vector2.left; //changing the direction of pacman to left
      }
        
      if(Input.GetAxis("Horizontal")>0){
        direction = Vector2.right; //changing the direction of pacman to right
       }

      rb.velocity = direction*speed;
       
      /*dirX = Input.GetAxis("Horizontal") * moveSpeed;
      dirZ = Input.GetAxis("Vertical") * moveSpeed;*/
    }
      void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Enemy"){
          Destroy(this.gameObject);
          SceneManager.LoadScene("Game Over");
        }
      }
    /*private void FixedUpdate() {
      {
        rb.velocity = new Vector3(rb.velocity.x, dirY, dirZ);
      }*/
} 