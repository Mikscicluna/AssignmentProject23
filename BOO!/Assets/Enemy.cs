using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string x = " ";
    private SphereCollider sc;
    [SerializeField]
    private float _speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        sc = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //translate the enemy position backwards (back due to it being on the z axis)
        transform.Translate(Vector3.back * _speed * Time.deltaTime);
        //if the enemy has gone below -7.39 on the y axis
        if(transform.position.z < -7.39f)
        {
            //transform.position = teleport
            float randomX = Random.Range(-4.15f,4.15f);
            _speed+=1f;
            transform.position = new Vector3(randomX,0.6f,6.45f);
        }
        //change the position to teleport from the top of the screen at random position on x axis
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ghost")
        {
            Destroy(this.gameObject);
        }
    }
    
    /*public void onCollisionEnter2D(Collision2D collision){
            destroyEnemy(collision,x);
    }

    public void destroyEnemy(Collision2D collision, string x){
        if(collision.gameObject.tag == "Ghost"){
            Destroy(this.gameObject);
            x = "Object Destroyed";
        }
    }*/
}
