using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour
{


    public float moveSpeed, strafeSpeed;
    private float move, strafe;
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        Move();
        Strafe();

    }

    private void Move()
    {
        Vector3 movement = transform.forward * move * moveSpeed * Time.deltaTime;
        rigidbody.MovePosition(rigidbody.position + movement);
    }
    private void Strafe()
    {
        Vector3 strafing = transform.right * strafe * strafeSpeed * Time.deltaTime;
        rigidbody.MovePosition(rigidbody.position + strafing);
    }
    private void Update()
    {
        move = Input.GetAxis("Vertical");
        strafe = Input.GetAxis("Horizontal");
    }
   
}