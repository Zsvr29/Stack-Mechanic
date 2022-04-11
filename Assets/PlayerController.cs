using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 direction;
    public float forwardSpeed;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

   
    void Update()
    {
       direction.z = forwardSpeed;

    }
    private void FixedUpdate()
    {
        characterController.Move(direction * Time.deltaTime);
    }
}
