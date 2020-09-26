using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Gun gun;
    private int Direction;

    private float DeSpawn = 10f;

    public float BulletSpeed;
    [Range(0, 1)] [SerializeField] private float MovementSmoothing;
    Vector3 Velocity = Vector3.zero;

    private Rigidbody2D rb2D;
    void Awake()
    {
        gun = GameObject.FindGameObjectWithTag("Player").GetComponent<Gun>();
        Direction = gun.DirectionNum;

        switch (Direction)
        {
            case 1:
                this.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 90);
                break;
            case 2:
                this.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -90);
                break;
            case 3:
                this.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
                break;
            case 4:
                this.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 180);
                break;
            case 5:
                this.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -45);
                break;
            case 6:
                this.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -135);
                break;
            case 7:
                this.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 45);
                break;
            case 8:
                this.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 135);
                break;

        }

        rb2D = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        DeSpawn -= Time.fixedDeltaTime;

        if(DeSpawn < 0)
        {
            Destroy(this.gameObject);
        }

        switch (Direction)
        {
            case 1:
               
                Vector3 Targetvelocity1 = new Vector3(1, 0, 0).normalized;
                rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, (Targetvelocity1) * BulletSpeed, ref Velocity, MovementSmoothing) * Time.fixedDeltaTime;
                break;
            case 2:
                Vector3 Targetvelocity2 = new Vector3(-1, 0, 0).normalized;
                rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, (Targetvelocity2 ) * BulletSpeed, ref Velocity, MovementSmoothing) * Time.fixedDeltaTime;
                break;
            case 3:
                Vector3 Targetvelocity3 = new Vector3(0, 1, 0).normalized;
                rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, (Targetvelocity3) * BulletSpeed, ref Velocity, MovementSmoothing) * Time.fixedDeltaTime;
                break;
            case 4:
                Vector3 Targetvelocity4 = new Vector3(0, -1, 0).normalized;
                rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, (Targetvelocity4) * BulletSpeed, ref Velocity, MovementSmoothing) * Time.fixedDeltaTime;
                break;
            case 5:
                Vector3 Targetvelocity5 = new Vector3(1, 1, 0).normalized;
                rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, (Targetvelocity5) * BulletSpeed, ref Velocity, MovementSmoothing) * Time.fixedDeltaTime;
                break;
            case 6:
                Vector3 Targetvelocity6 = new Vector3(1, -1, 0).normalized;
                rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, (Targetvelocity6) * BulletSpeed, ref Velocity, MovementSmoothing) * Time.fixedDeltaTime;
                break;
            case 7:
                Vector3 Targetvelocity7 = new Vector3(-1, 1, 0).normalized;
                rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, (Targetvelocity7) * BulletSpeed, ref Velocity, MovementSmoothing) * Time.fixedDeltaTime;
                break;
            case 8:
                Vector3 Targetvelocity8 = new Vector3(-1, -1, 0).normalized;
                rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, (Targetvelocity8) * BulletSpeed, ref Velocity, MovementSmoothing) * Time.fixedDeltaTime;
                break;
        }
    }
}
