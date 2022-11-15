using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float rand = Random.Range(-0.7f,3.8f);
        if (transform.position.x<=-3.7) {
            transform.position = new Vector3(3.7f,rand,transform.position.z);
        }
        transform.Translate(-0.1f*Time.deltaTime,0,0);
    }
}
