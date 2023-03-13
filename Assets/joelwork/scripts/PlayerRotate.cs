using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public GameObject frontPoint;
    public GameObject backPoint;
    public GameObject rightPoint;
    public GameObject leftPoint;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 targetPosition = frontPoint.transform.position;
            Vector3 targetDirection = targetPosition - transform.position;
            float step = rotationSpeed * Time.deltaTime;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, step, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 targetPosition = rightPoint.transform.position;
            Vector3 targetDirection = targetPosition - transform.position;
            float step = rotationSpeed * Time.deltaTime;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, step, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 targetPosition = backPoint.transform.position;
            Vector3 targetDirection = targetPosition - transform.position;
            float step = rotationSpeed * Time.deltaTime;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, step, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 targetPosition = leftPoint.transform.position;
            Vector3 targetDirection = targetPosition - transform.position;
            float step = rotationSpeed * Time.deltaTime;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, step, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }


    }
}
