using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyLook : MonoBehaviour
{
    private GameObject Player;

    public float Speed;
    [Range(0, 1)] [SerializeField] private float MovementSmoothing;
    Vector3 Velocity = Vector3.zero;

    private Rigidbody2D rb2D;
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        LookAtPlayer();
        MoveToPlayer();
    }

    void LookAtPlayer()
    {
        Vector2 target = new Vector2(Player.transform.position.x, Player.transform.position.y);

        Vector2 direction = new Vector2(target.x - transform.position.x, target.y - transform.position.y);

        transform.up  = direction;
    }
    
    void MoveToPlayer()
    {
       Vector3 Targetvelocity = transform.up * Speed * 10;

        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, Targetvelocity, ref Velocity, MovementSmoothing) * Time.fixedDeltaTime;
    }
}
