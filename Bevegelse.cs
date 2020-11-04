using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bevegelse : MonoBehaviour
{
    public float mSpeed;
    public Rigidbody rb;

    void Start()
    {
        mSpeed = 10f;
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        transform.Translate(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, mSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        {

        }
    }
}
