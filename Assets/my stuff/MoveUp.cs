using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR.Interaction.Toolkit;

public class MoveUp : MonoBehaviour
{
    public float moveSpeed = 2f;

    public InputActionProperty moveUpButton;
    public InputActionProperty moveDownButton;

    public CharacterController controller;


    void Update()
    {
        Vector3 move = Vector3.zero;

        if (moveUpButton.action.IsPressed())
        {
            move += Vector3.up;
        }

        if (moveDownButton.action.IsPressed())
        {
            move += Vector3.down;
        }

        if (move != Vector3.zero)
        {
            controller.Move(move * moveSpeed * Time.deltaTime);
        }
    }
}
