using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;
    Vector3 rotationRight = new Vector3(0, 30, 0);
    Vector3 rotationLeft = new Vector3(0, -30, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if(forwardForce > 1500f){
            forwardForce = 1500f;
        }
        rb.AddForce(0,0,forwardForce*Time.deltaTime);
        /*
        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }*/
        
        if (Input.GetKey("d"))
        {
        Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotationRight);
        rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
        Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotationLeft);
        rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

    }
}
