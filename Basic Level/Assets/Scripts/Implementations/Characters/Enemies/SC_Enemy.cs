using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SC_Enemy : SC_ConcreteCharacter
{
    public SC_ConcreteWeapon sc_weapon;
    protected float lastShootTime;
    public int _init_lives_count;
    public float shootInterval = 1f; // Interval between shoots in seconds


    private void Awake()
    {
        init_lives_count = _init_lives_count;
        Init();

    }
    public virtual void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player") // player collider touch 'my_collider'
        {
            EnemyHit();
        }
    }

    private void Update()
    {
        if (Time.time - lastShootTime >= shootInterval)
        {
            float direction = CalcShootDirection();
            sc_weapon.Shoot(direction);
            lastShootTime = Time.time;
        }
    }

    protected virtual float CalcShootDirection()
    {
        GameObject mario = GameObject.FindGameObjectWithTag("Player");
        Transform target = mario.transform;
        return Mathf.Sign(target.position.x - transform.position.x);
    }

    private void EnemyHit()
    {
        gameObject.SetActive(false);
    }


}


