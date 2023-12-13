using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    KeyCode rightKey, leftKey, forwardKey, backwardKey;
    [SerializeField]
    Rigidbody rb;
    [SerializeField]
    Transform car;
    [SerializeField]
    float rotateSpeed = 40;


    Vector3 rotationRight = new Vector3(0, 40, 0);
    Vector3 rotationLeft = new Vector3(0, -40, 0);

    void Update()
    {
        if (Input.GetKey(leftKey))
        {
            Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationLeft);
        }
        if (Input.GetKey(rightKey))
        {
            Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationRight);
        }
        if (Input.GetKey(forwardKey))
        {
            this.transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(backwardKey))
        {
            this.transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
    }


}
