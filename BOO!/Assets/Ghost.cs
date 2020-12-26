using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    private Rigidbody rb;
    privat float moveSpeed;
    private float dirX, dirZ;

//Use below for initialization
    private void Start () {
      moveSpeed = 3.8f;
      rb = GetComponent<Rigidbody>();
    }
    //Update is called once per frame
    private void Update () {
      dirX = Input.GetAxis("Horizontal") * moveSpeed;
      dirZ = Input.GetAxis("Vertical") * moveSpeed;
    }
    private void private void FixedUpdate() {
      {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
      }
} 