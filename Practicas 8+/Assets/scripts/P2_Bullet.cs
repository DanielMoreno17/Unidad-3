using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_Bullet : MonoBehaviour
{
    [SerializeField] float fuerza;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
         rb.AddForce(transform.forward *  fuerza, ForceMode.VelocityChange);
        //rb.AddForce(transform.forward * fuerza, ForceMode.VelocityChange);
    }
}
