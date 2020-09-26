using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float ShootRate;
    private float ConstRate;

    public GameObject Bullet;

    [HideInInspector] public int DirectionNum;
    void Awake()
    {
        ConstRate = ShootRate;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            ShootRate -= Time.fixedDeltaTime;

            if (ShootRate < 0)
            {
                ShootRate = ConstRate;
                Shoot();
            }
        }
        else
        {
            ShootRate = 0;
        }
        
    }
    void Shoot()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                DirectionNum = 1;
                Instantiate(Bullet, this.transform.position, Quaternion.identity);
            }
            if (!Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                DirectionNum = 1;
                Instantiate(Bullet, this.transform.position, Quaternion.identity);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                DirectionNum = 5;
                Instantiate(Bullet, this.transform.position, Quaternion.identity);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                DirectionNum = 6;
                Instantiate(Bullet, this.transform.position, Quaternion.identity);
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
           
            if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
                DirectionNum = 2;
                Instantiate(Bullet, this.transform.position, Quaternion.identity);
            }
            if (!Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
                DirectionNum = 2;
                Instantiate(Bullet, this.transform.position, Quaternion.identity);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                DirectionNum = 7;
                Instantiate(Bullet, this.transform.position, Quaternion.identity);
            }
             if(Input.GetKey(KeyCode.DownArrow))
            {
                DirectionNum = 8;
                Instantiate(Bullet, this.transform.position, Quaternion.identity);
            }
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            DirectionNum = 3;
            Instantiate(Bullet, this.transform.position, Quaternion.identity);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            DirectionNum = 4;
            Instantiate(Bullet, this.transform.position, Quaternion.identity);
        }
    }
}
