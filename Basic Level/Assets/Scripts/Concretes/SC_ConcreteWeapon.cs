using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SC_ConcreteWeapon : MonoBehaviour, IWeapon
{

    public float xSpeed = 100f;
    public float ySpeed = 5f;
    public float destroyTime = 5f;
    //public int effect = 1;
    //public string target_tag;
    //private const string player_tag = "Player";
    //private const string enemy_tag = "Enemy";
    protected bool _isEquip = true;
    protected Rigidbody2D body;
    public GameObject wep;

    /*
    private void Awake()
    {
        effect = effect * -1;
    }
    */
    public virtual void Shoot(float direction=1)
    {
        if (_isEquip)
        {
            GameObject _wep = Instantiate(wep, transform.position, new Quaternion());
            _wep.transform.localScale = new Vector3(direction, 1, 1);
            _wep.GetComponent<Rigidbody2D>().AddForce(new Vector3(xSpeed * direction, ySpeed, 0));
            StartCoroutine(DestroyObject(_wep));
        }
    }

    public void Reload()
    {
        _isEquip = true;
    }
    private IEnumerator DestroyObject(GameObject obj)
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(obj);
    }

    /*
    public void OnTriggerEnter2D(Collider2D other)
    {
        {
            string other_tag_full = other.gameObject.tag;
            string[] other_tag_parts = other_tag_full.Split('@');
            string other_tag = other_tag_parts[0];

            if (other_tag == target_tag)
            {
                this.gameObject.SetActive(false);
                other.GetComponent<SC_ConcreteCharacter>().Hit(effect);

            }
        }
    }
    */
}