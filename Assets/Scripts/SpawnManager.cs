using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipe;
    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe),0.0f,3);
    }

    public void SpawnPipe() {
        GameObject newPipe = Instantiate(pipe);
    }
}
