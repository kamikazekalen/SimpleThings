using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BasketController : MonoBehaviour {

    public Vector3 velocity = Vector3.zero;
    private Rigidbody rb;
    private float JumpForce = 3.0f;
    private float ForwardSpeed = 1.0f;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    // void xAnimeTimer_Tick()
    // {
    //     int count;

    //     xAnimeTimer = count = 0;
    //     xAnimePictureBox = count = 0;

    //     this.xAnimeTimer.Stop();

    //     //   start point   end point   speed
    //     for (count = 1350; count >= 0; count -=2)
    //     {
    //         this.xAnimePictureBox.Left = count;
    //     }
    //     for (count = 810; count >= 0; count -= 2)
    //     {
    //         this.xAnimePictureBox.Top = count;
    //     }
    // }

    void Update(){
        rb.AddForce(Vector3.up * ForwardSpeed);
        if (Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            Debug.Log("Added Force");
        }
        velocity = rb.velocity;
    }
}