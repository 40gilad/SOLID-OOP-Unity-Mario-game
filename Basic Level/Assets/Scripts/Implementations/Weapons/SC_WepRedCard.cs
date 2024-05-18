using UnityEngine;

public class SC_WepRedCard : SC_ConcreteWeapon
{
    private void Start()
    {
        body = wep.GetComponent<Rigidbody2D>();
    }
}