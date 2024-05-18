using UnityEngine;

public class SC_WepFireball : SC_ConcreteWeapon
{
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
}