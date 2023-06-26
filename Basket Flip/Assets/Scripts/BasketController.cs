using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class BasketController : MonoBehaviour {

    public Vector3 velocity = Vector3.zero;
    private Rigidbody rb;
    private float JumpForce = 8.0f;
    private float ForwardSpeed = 1.0f;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void Update(){
        rb.AddForce(force: Vector3.forward * ForwardSpeed);
        if ((Input.GetKeyDown(key: KeyCode.Space)) & (rb.position.y <= 0.5) ){
            rb.AddForce(force: Vector3.up * JumpForce, mode: ForceMode.Impulse);
            Debug.Log(message: "Added Force");
        }
        velocity = rb.velocity;
    }
}