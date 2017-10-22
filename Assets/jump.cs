using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public int force = 50;
    private Rigidbody selfRigidbody;
    private bool onGround;
    private Vector3 oldVelocity;
    // Use this for initialization
    void Start()
    {
        selfRigidbody = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (selfRigidbody.velocity.y < 1 && selfRigidbody.velocity.y >= 0)
        {
            Vector3 v = selfRigidbody.velocity;
            v.y = 0;
            selfRigidbody.velocity = v;
            
        }
   
        if (selfRigidbody.velocity.y == 0 && !onGround)
        {
            onGround = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space) && onGround)
        {
            selfRigidbody.AddForce(0, force, 0, ForceMode.Impulse);
            onGround = false;
        }
        oldVelocity = selfRigidbody.velocity;

    }
}
