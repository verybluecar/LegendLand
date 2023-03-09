using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAwayFromCamera : MonoBehaviour
{
    public GameObject theCamera;
    public GameObject secondCamera;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = theCamera.transform.position;
        Vector3 objectPosition = transform.position;
        Vector3 objectDirection = objectPosition - targetPosition;
        Quaternion targetRotation = Quaternion.LookRotation(objectDirection, Vector3.up);
        targetRotation = Quaternion.Euler(0f, targetRotation.eulerAngles.y, 0f); // Set y component to zero
        float step = rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, step);
       

    }
}
