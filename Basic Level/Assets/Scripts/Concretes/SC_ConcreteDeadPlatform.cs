using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SC_ConcreteDeadPlatform : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnCollisionEnter2D " + other.gameObject.name);
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<SC_Mario>().Die();
        }
    }
}
