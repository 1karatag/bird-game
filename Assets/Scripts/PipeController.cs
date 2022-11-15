using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeController : MonoBehaviour
{
    //maks 2 min -2
    void Start()
    {
        float rand = Random.Range(-2, 2);
        transform.position = new Vector3(3.5f, rand,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -3.3f) {
            Destroy(gameObject);
            Debug.Log("yok oldu");
        }
        transform.Translate(-0.02f, 0, 0);
    }
}
