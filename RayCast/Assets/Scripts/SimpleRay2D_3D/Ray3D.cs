using UnityEngine;

public class Ray3D : MonoBehaviour
{
    //Leia a informação na classe Ray2D ********************************
 

    public Transform origin;
    public LayerMask mask;

    void Update()
    {
        RayModelOne();
    }


    public void RayModelOne()
    {
        RaycastHit hit;
        Debug.DrawRay(origin.position, transform.TransformDirection(Vector3.right) * 3, Color.green);

        if (Physics.Raycast(origin.position, transform.TransformDirection(Vector3.right), out hit, 3))
        {
            if (hit.collider)
            {
                Debug.Log(hit.collider.name);
            }
        }
    }
}
