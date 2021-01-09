using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float torqueMultiplier = 1f;
    public Rigidbody rb;
    public bool useGravity;

    void Start()
    {
        rb.useGravity = useGravity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotate(Vector3 rotation)
    {
        rb.AddTorque(torqueMultiplier * rotation);
    }

}
