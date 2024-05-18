using UnityEngine;

public class SC_CameraFollow : MonoBehaviour
{
    private GameObject target; // Reference to Mario's transform
    public float smoothSpeed = 0.125f; // How quickly the camera follows Mario
    public Vector3 offset; // Offset from Mario
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }
    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.transform.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
