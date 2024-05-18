using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_WepAxe : SC_ConcreteWeapon
{
    
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        _isEquip = false;
    }

    public override void Shoot(float direction = 1)
    {
        base.Shoot(direction);
        _isEquip = false;
    }
}
