using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    //Variables for movement speed
    [SerializeField] private float speed;
    private Vector3 _moveDir;

    //Variables for the jump
    [SerializeField] private float JumpFrc;
    [SerializeField] private float Cooldown;
    float lastjump;
    private Rigidbody rb;

    //Bool value for checking if my weapon is equipped
    private bool isWeaponEquipped = false;


    void Start()
    {
        InputManager.Init(this);
        InputManager.GameMode();
        rb = GetComponent<Rigidbody>(); //Getting the rigid body for the jump of the cube
        
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime * _moveDir; //Movment code for WASD InputSystem

    }


    public void SetMovementDirection(Vector3 newDirection) //Movment variable for WASD InputSystem
    {
        _moveDir = newDirection;
    }

    internal void SetMovementDirection() //Unity offered a fix since the above variable wasn't working
    {
        throw new NotImplementedException();
    }
    public void Jump() //Jump Function
    {
        if (Time.time - lastjump < Cooldown) //Jump cooldown
        {
            return;
        }
        lastjump = Time.time;
        Debug.Log("Jump Called");
        rb.AddForce(Vector3.up * JumpFrc, ForceMode.Impulse); //Jump code

    }

    public void WeaponEquip()
    {
        if (Input.GetKeyDown(KeyCode.E)) //Checks if E is pressed
        {
            isWeaponEquipped = !isWeaponEquipped; //Toggles between both states
            
            if (isWeaponEquipped)
            {
                Debug.Log("I have equipped a weapon!");
            }
            else
            {
                Debug.Log("I have Unequipped a weapon!");
            }
        }
    }
}



