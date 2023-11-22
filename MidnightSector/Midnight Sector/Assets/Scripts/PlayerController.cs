using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float mapWidth = 5.0f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Use accelerometer input for mobile
        Vector3 newPosition = transform.position + Vector3.right * horizontalInput * moveSpeed * Time.deltaTime;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        transform.position = newPosition;
    }
}
