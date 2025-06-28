using UnityEngine;

public class CameraFollow_NVBang : MonoBehaviour
{
    public Transform target;          // Mario
    public Vector3 offset;            // Khoảng cách lệch
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Camera chỉ theo trục X, giữ nguyên Y, Z
        transform.position = new Vector3(smoothedPosition.x, transform.position.y, -10f);
    }
}
