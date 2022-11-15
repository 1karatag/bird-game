using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class PipeController : MonoBehaviour
{
    
    private void Start()
    {
        float rand = Random.Range(-2, 2);
        transform.position = new Vector3(3.5f, rand,transform.position.z);
    }

    
    private void Update()
    {
        if (Time.timeScale==0) {
            Destroy(gameObject);
        }
        if (transform.position.x <= -3.3f) {
            Destroy(gameObject);
            
        }
        transform.Translate(-0.02f, 0, 0);
    }
    
}

