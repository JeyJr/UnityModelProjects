using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontCollisionDetectRay2D : MonoBehaviour
{
    [SerializeField] private float rangeToDetect;
    [SerializeField] private float rangeToShoot;
    public LayerMask enemyMask;
    public Transform origin;

    public GameObject bullet;

    private void FixedUpdate()
    {
        DetectEnemy();
        ShootEnemy();
    }


    internal void DetectEnemy()
    {
        //Direção do raycast é de acordo com a rotação do obj

        RaycastHit2D hit = Physics2D.Raycast(origin.position, transform.TransformDirection(Vector2.right), rangeToDetect, enemyMask);
        Debug.DrawRay(origin.position, transform.TransformDirection(Vector2.right) * rangeToDetect, Color.blue);
        if (hit)
        {
            Debug.Log($"Inimigo encontrado: {hit.collider.name}");
        }
    }

    internal void ShootEnemy()
    {
        RaycastHit2D hit = Physics2D.Raycast(origin.position, transform.TransformDirection(Vector2.right), rangeToShoot, enemyMask);
        Debug.DrawRay(origin.position, transform.TransformDirection(Vector2.right) * rangeToShoot, Color.yellow);
        if (hit)
        {
            Instantiate(bullet, origin.position, Quaternion.Euler(0, transform.eulerAngles.y, 0));
        }
    }


}
