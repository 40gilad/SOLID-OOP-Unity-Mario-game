using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public abstract class SC_ConcreteCharacter : MonoBehaviour, ICharacter
{
    protected SC_LivesManager lives_manager;
    protected int init_lives_count;


    protected void Init()
    {
        lives_manager = new GameObject("LivesManager").AddComponent<SC_LivesManager>();
        lives_manager.Init(init_lives_count);
    }
    public virtual void Die()
    {
        transform.gameObject.SetActive(false);
    }

    public virtual void Hit(int effect=-1)
    {
       this.lives_manager.DecLives(effect);
        int currlives = lives_manager.GetLives();
        if (currlives < 0)
            Die();
    }



}

