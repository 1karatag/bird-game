using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnTime;
    public GameObject pipe;
    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe),0.1f,spawnTime);
    }

    public void SpawnPipe() {
        GameObject newPipe = Instantiate(pipe);
    }
}
