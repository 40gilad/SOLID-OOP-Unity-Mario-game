using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public interface IWeapon
{
    void Shoot(float direction=1);
    //public void OnTriggerEnter2D(Collider2D other);

}
