using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject playerBall;
    Transform playerTransform;
    Camera mainCamera;
    private Vector3 cameraOffset;
    // Start is called before the first frame update
    void Start()
    {
        playerBall = GameObject.FindGameObjectWithTag("Player");
        playerTransform = playerBall.transform;
        Vector3 playerPosition = playerBall.transform.position;

        transform.position = new Vector3(playerPosition.x, playerPosition.y + 0.5f, playerPosition.z - 1.0f);
        cameraOffset = transform.position - playerTransform.position; // Default camera position
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = playerTransform.position + cameraOffset;
        transform.position = newPos;
        
        transform.LookAt(playerBall.transform.position);
    }
}
