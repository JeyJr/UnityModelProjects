using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyAddForce : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float forceForce, forceImpulse, forceVel, forceAce;
    [SerializeField] private Camera cam;

    private void OnEnable()
    {
        CamSetup(new Vector3(0, 7, -17), new Vector3(18, 0, 0), 4.25f);
    }
    private void OnDisable()
    {
        CamSetup(new Vector3(0, 27, -24), new Vector3(47, 0, 0), 10);
    }
    private void CamSetup(Vector3 pV3, Vector3 rV3, float size){
        cam.transform.position = pV3;
        cam.transform.rotation = Quaternion.Euler(rV3);
        cam.GetComponent<Camera>().orthographicSize = size;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            rb.AddForce(Vector3.up * forceForce, ForceMode.Force);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            rb.AddForce(Vector3.up * forceImpulse, ForceMode.Impulse);
        }        
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            rb.AddForce(Vector3.up * forceVel, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            rb.AddForce(Vector3.up * forceAce, ForceMode.Acceleration);
        }
    }
}
