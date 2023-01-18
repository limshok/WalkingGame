using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    [SerializeField] private float speed; 
    [SerializeField] private float jumpForce; 
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = new Vector3(Input.GetAxis("Horizontal")*speed, Input.GetKeyDown(KeyCode.Space)?jumpForce:_rb.velocity.y,Input.GetAxis("Vertical")*speed);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(new Vector3(0,jumpForce,0),ForceMode.VelocityChange);
        }
    }
}
