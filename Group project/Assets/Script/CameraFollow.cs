
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothing = 0.3f;
    public Vector3 offset;

    private Vector3 velocity = Vector3.zero;

    private Vector3 desiredPos;

    void LateUpdate()
    {
        desiredPos = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, desiredPos, ref velocity, smoothing);
        //transform.LookAt(target);
    }
}
