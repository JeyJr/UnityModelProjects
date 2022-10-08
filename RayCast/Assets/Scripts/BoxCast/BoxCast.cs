using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCast : MonoBehaviour
{
    
    [SerializeField] private float range;
    [SerializeField] private float maxDistance;
    [SerializeField] private Vector3 size;
    [SerializeField] private RaycastHit hit;
    [SerializeField] private Transform centerBox;

    private void FixedUpdate() {
        
        bool hitDetect = Physics.BoxCast(centerBox.position, size, transform.forward, out hit, Quaternion.identity);

        if(hitDetect){
            Debug.Log($"Encontrou {hit.collider.name}");
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        //Gizmos.DrawRay(transform.position, centerBox.position);
        Gizmos.DrawWireCube(centerBox.position, size);
    }
}
