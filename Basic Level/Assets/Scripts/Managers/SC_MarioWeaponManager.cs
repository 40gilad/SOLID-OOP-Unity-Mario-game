using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MarioWeaponManager : MonoBehaviour
{
    public SC_WepFireball _fireBallWeapon;
    public SC_WepAxe _axeBallWeapon;
    public SC_ColAxe _axeCol;
    public SC_AxeColManager _axeColManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            if (_fireBallWeapon != null)
            {   
                float direction = GameObject.FindGameObjectWithTag("Player").transform.localScale.x;
                _fireBallWeapon.Shoot(direction);
            }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (_axeBallWeapon != null)
            {
                if (_axeColManager.GetCount() > 0)
                {
                    _axeCol.OnDeCollect();
                    float direction = GameObject.FindGameObjectWithTag("Player").transform.localScale.x;
                    _axeBallWeapon.Shoot(direction);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (_axeBallWeapon != null)
            {
                _axeBallWeapon.Reload();
            }
        }
    }



}