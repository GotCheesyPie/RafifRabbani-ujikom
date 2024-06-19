using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 playerVelocity;
    public float playerSpeed;
    public Animator animator;
    public SpawnFood spawnFood;
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        animator.SetFloat("rightSpeed", move.x);
        controller.Move(move * Time.deltaTime * playerSpeed);

        controller.Move(playerVelocity * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            ThrowFood();
        }
    }

    void ThrowFood()
    {
        animator.SetTrigger("throw");
        spawnFood.Spawn();
    }
}
