using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class basketMove : MonoBehaviour
{
    public float speed = 1f;
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        Vector3 movement = new Vector3(moveInput, 0, 0) * speed * Time.deltaTime;
        transform.position += movement;
    }
}
