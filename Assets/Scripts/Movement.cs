using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public int speed  ;
    private Rigidbody _comRigidbody;
   

    private void Awake()
    {
        _comRigidbody = GetComponent<Rigidbody>();
       
    }
    

    public void Movimiento(InputAction.CallbackContext contex)
    {
        
        Vector2 input = contex.ReadValue<Vector2>();
        _comRigidbody.AddForce(new Vector3(input.x, 0f , input.y) * speed); 
    }
    }
   

