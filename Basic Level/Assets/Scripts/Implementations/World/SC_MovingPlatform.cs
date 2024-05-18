using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MovingPlatform : SC_Movment
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(transform);
            // make sticky floor
        }


    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Reset the player's parent to null
            other.transform.SetParent(null);
        }
    }
}
