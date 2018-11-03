﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowScript : MonoBehaviour
{

    int dir;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
