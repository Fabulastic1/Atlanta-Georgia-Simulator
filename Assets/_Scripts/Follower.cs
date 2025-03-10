using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    
    public Transform player;

    public float smoothSpeed = 0.25f;
    private Vector3 offset = new Vector3(0f, 0f, -10f);
    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        Vector3 desirePosition = player.position + offset;

        transform.position = Vector3.SmoothDamp(transform.position, desirePosition, ref velocity, smoothSpeed);
    }
}
