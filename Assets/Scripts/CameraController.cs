using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed;
    public Transform target;
    public Vector2 minPosition;
    public Vector2 maxPosition;
    private float cameraSize;
    private float cameraRatio;

    void Start()
    {
        Camera camera = Camera.main;
        cameraSize = camera.orthographicSize;
        cameraRatio = (maxPosition.x + cameraSize) / 2.0f;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector2 position = Vector2.Lerp(transform.position, target.position, speed);
        float camY = Mathf.Clamp(position.y, minPosition.y + cameraSize, maxPosition.y - cameraSize);
        float camX = Mathf.Clamp(position.x, minPosition.x + cameraRatio, maxPosition.x - cameraRatio);
        transform.position = new Vector3(camX, camY, transform.position.z);
    }
}
