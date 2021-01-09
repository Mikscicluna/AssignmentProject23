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
    void OnDestroy() {
        SceneManager.LoadScene("Game Over");
    }
    void Start() {
      rb = GetComponent<Rigidbody>();
    }
    //Update is called once per frame
    void Update() {
      speed = 7f;
      if(Input.GetAxis("Horizontal")<0){
        direction = Vector2.left; //changing the direction of ghost to left
      }
        
      if(Input.GetAxis("Horizontal")>0){
<<<<<<< Updated upstream:BOO!/Assets/Ghost.cs
        direction = Vector2.right; //changing the direction of ghost to right
      }

    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.tag == "Flashlight")
      {
        Destroy(this.gameObject);
      }
    }

      rb.velocity = direction*speed;

=======
        direction = Vector2.right; //changing the direction of pacman to right
        }

      rb.velocity = direction*speed;
      
<<<<<<< Updated upstream:BOO!/Assets/Ghost.cs
>>>>>>> Stashed changes:BOO!/Assets/Scripts/Ghost.cs
=======
>>>>>>> Stashed changes:BOO!/Assets/Scripts/Ghost.cs
      
      /*dirX = Input.GetAxis("Horizontal") * moveSpeed;
      dirZ = Input.GetAxis("Vertical") * moveSpeed;*/
    }
    /*private void FixedUpdate() {
      {
        rb.velocity = new Vector3(rb.velocity.x, dirY, dirZ);
      }*/
} 