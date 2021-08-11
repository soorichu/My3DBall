using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    float updown; float leftright;
    float velocity = 0.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updown -= Input.GetAxis("Horizontal");
        leftright -= Input.GetAxis("Vertical");

        transform.rotation = Quaternion.Euler(leftright * velocity, 0, updown * velocity);
    }
}
