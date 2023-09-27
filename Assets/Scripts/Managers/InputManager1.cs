using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CubeController : MonoBehaviour
{
    public float JumpFrc = 5f;
    public float jumpCooldown = 1f;
    private Rigidbody rb;
    private float lastJumpTime;


    void Start()
    {
        rb  = GetComponent<Rigidbody>();
        lastJumpTime = -jumpCooldown;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastJumpTime >= jumpCooldown)
        {
            Jump();
            lastJumpTime = Time.time;
        }
    }
    void Jump() 
    {
        rb.AddForce(Vector3.up * JumpFrc, ForceMode.Impulse);
    }
}
