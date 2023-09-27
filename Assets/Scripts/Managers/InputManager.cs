using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class InputManager 
{

    private static Controls _controls;

    public static void Init (Player myPlayer)
    {
        _controls = new Controls();

        _controls.Game.Movement.performed += jeff => 
        {

            myPlayer.SetMovementDirection(jeff.ReadValue<Vector3>());
            Debug.Log("You Are Moving! ");
        };

        _controls.Permenant.Enable();
    }

    public static void GameMode()
    {
        _controls.Game.Enable();
        _controls.UI.Disable();

    }

    public static void UImode()
    {
        _controls.Game.Disable();
        _controls.UI.Enable();


    }






}
