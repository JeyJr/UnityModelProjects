using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private bool isWalk;
    [SerializeField] private Vector3 directionMove;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private LayerMask groundMask;


    private void FixedUpdate()
    {
        if (isWalk)
        {
            transform.position = directionMove;
        }
    }
    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, groundMask))
            {
                directionMove = Vector3.MoveTowards(transform.position, hit.point, 4 * Time.deltaTime);
                isWalk = true;
            }
        }
    }



    public void SetPlayerMove(bool isWalk, Vector3 directionMove)
    {
        this.isWalk = isWalk;
        this.directionMove = directionMove;
    }
}