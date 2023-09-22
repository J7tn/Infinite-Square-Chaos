using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    public List<Color> colors = new List<Color>();
    private void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Count)];
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            ChangeColor();
        }
    }
}
