using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotateSpeed;
    public Transform target;
    public Transform pivot;
    
    void Start()
    {
        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float horizantal = Input.GetAxis("Mouse X")* rotateSpeed;
        target.Rotate(0, horizantal, 0); 

        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        pivot.Rotate(-vertical, 0, 0);

        if(transform.position.y < target.position.y)
        {
            transform.position = new Vector3(transform.position.x, target.position.y, target.position.z); 
        }
        /*if (pivot.rotation.eulerAngles.x > 45f && pivot.rotation.eulerAngles.x < 180f)
        {
            pivot.rotation = Quaternion.Euler(-45f, 0, 0);
        }*/
            
    }
}
