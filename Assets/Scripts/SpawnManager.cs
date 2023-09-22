using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject objectToSpawn;
    void Start()
    {
        InvokeRepeating("SpawnCube", 1, 1);
    }

    void SpawnCube()
    {
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
}
