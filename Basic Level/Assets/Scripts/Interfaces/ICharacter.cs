using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter 
{
    void Hit(int effect=-1);

    void Die();

}
