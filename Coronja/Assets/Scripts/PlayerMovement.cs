using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    //components
    private Rigidbody2D rb2D;
   
    //variabler
    Vector3 Velocity = Vector3.zero;
    public float Speed;
    [Range(0, 1)] [SerializeField] private float MovementSmoothing;
   
    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        float yAxis = Input.GetAxisRaw("Vertical");

        


        Vector3 Targetvelocity = new Vector3 ( xAxis, yAxis, 0).normalized;

        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, (Targetvelocity * 10) * Speed , ref Velocity, MovementSmoothing) * Time.fixedDeltaTime;
    }
      
}

