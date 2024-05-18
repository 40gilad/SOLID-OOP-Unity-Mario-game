using UnityEngine;

public class SC_SlidingFootballPlayer : SC_Enemy
{
    private bool isActivated = true;
    private Vector3 initialPosition = Vector3.zero;
    public float moveSpeed = 2f;
    public float moveDistance = 3f;
    private bool moveRight = true;

    void Start()
    {
        initialPosition = transform.position;
    }
    public void Activate()
    {
        isActivated = true;
    }

    void Update()
    {

        if (isActivated)
        {
            Vector3 targetPosition;
            if (moveRight)
            {
                targetPosition = initialPosition + Vector3.right * moveDistance;
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 180f, transform.rotation.eulerAngles.z);

            }
            else
            {
                targetPosition = initialPosition - Vector3.right * moveDistance;
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, transform.rotation.eulerAngles.z);
            }
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
                moveRight = !moveRight;
        }
    }
    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<SC_Mario>().Die();
        }
    }
}