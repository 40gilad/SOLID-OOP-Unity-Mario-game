using UnityEngine;

public class SC_ConcreteBullet : MonoBehaviour, IBullet
{
    public string target_tag;
    private const string player_tag = "Player";
    private const string enemy_tag = "Enemy";
    public int effect = 1;

    private void Awake()
    {
        effect = effect * -1;
    }
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
}