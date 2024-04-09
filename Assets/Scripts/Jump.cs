using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Jump : MonoBehaviour
{
    private Rigidbody _compRigbody;
    public float jump = 120f;

    void Start()
    {
        _compRigbody = GetComponent<Rigidbody>();
    }

    public void Saltarpe(InputAction.CallbackContext Context)
    {
        _compRigbody.AddForce(Vector3.up * jump);
        Debug.Log("Saltarin:v");
    }
}
