using UnityEngine;

public class SC_ConcreteCollectible : MonoBehaviour, ICollectible
{
    public delegate void CollectibleCollisionHandler(string _textMeshPro_name);
    public static event CollectibleCollisionHandler ColCollected;
    public delegate void CollectibDecollectHandler(string _textMeshPro_name);
    public static event CollectibDecollectHandler DeCollected;

    protected string _textMeshPro_name;

    protected virtual void OnCollect()
    {
        if (ColCollected != null)
            ColCollected(_textMeshPro_name);
    }
    public virtual void OnDeCollect(int _count = 1)
    {
        if (DeCollected != null)
            DeCollected(_textMeshPro_name);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        { // player collider touch 'my_collider'
            Destroy(gameObject);
            OnCollect();
        }
    }
}