using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovePosition : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float moveSpeed, rotSpeed;
    private float y;

    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0) MoveObj();
        else transform.rotation = Quaternion.Euler(0, y,0);
    }

    private void MoveObj()
    {
        Vector3 i = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        rb.MovePosition(i * moveSpeed * Time.deltaTime + transform.position);


        float angle = Mathf.Atan2(i.x, i.z) * Mathf.Rad2Deg;
        Quaternion b = Quaternion.AngleAxis(angle, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, b, Time.deltaTime * rotSpeed);

        y = transform.localEulerAngles.y;
    }



}
