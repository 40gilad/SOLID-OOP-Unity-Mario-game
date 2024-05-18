using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBullet
{
    public void OnTriggerEnter2D(Collider2D other);

}
