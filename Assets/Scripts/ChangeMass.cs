using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMass : MonoBehaviour
{
    private void MassChange()
    {
        GetComponent<Rigidbody>().mass = Random.Range(0f, 10f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            MassChange();
        }
    }
}