﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dystroyghost : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }


        
    }

