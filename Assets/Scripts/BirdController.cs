using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    Rigidbody2D body;
    void Start()
    {
        
        body = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("as");
            body.velocity = Vector3.up * speed * Time.deltaTime;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 60);
        }
        else {
            if (transform.rotation.z>0) {
                transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, rotationSpeed);
            }
        }
    }
}
