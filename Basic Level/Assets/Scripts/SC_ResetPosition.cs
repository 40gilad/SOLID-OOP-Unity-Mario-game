using UnityEngine;

public class SC_ResetPosition : MonoBehaviour
{
    private Vector3 startPosition;
    private GameObject mario;

    void Start()
    {
        mario = GameObject.Find("Sprite_Mario"); // Get reference to Rigidbody2D component
        startPosition = mario.transform.position;
    }

    public void OnResetPosition()
    {
        if (mario != null)
            mario.transform.position = startPosition;
            //transform.position = startPosition; // Set position to start position
    }
}
