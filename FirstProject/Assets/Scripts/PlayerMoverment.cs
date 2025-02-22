using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoverment : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce *  Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < 0f) {
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
