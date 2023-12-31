using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDirection : MonoBehaviour
{
    public Vector3 RandomVector(float min, float max)
    {
        var x = Random.Range(min, max);
        var y = Random.Range(min, max);
        var z = Random.Range(min, max);
        return new Vector3(x, y, z);
    }
    void Start()
    {
        var rb = GetComponent<Rigidbody>();
        rb.velocity = RandomVector(-2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
