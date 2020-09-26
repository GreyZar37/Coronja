using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    public Transform user;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.localRotation = Quaternion.Euler(0,0, -user.transform.eulerAngles.z) ;

    }
}
