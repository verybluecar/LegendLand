using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject Hand;
    public bool CanPickUp;
    public bool PickedUp;
    public bool pickUpTimer;

    public GameObject pickUpTarget;

    private Vector3 target;
    private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        
        target = Hand.transform.position;
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (CanPickUp == true && Input.GetKey(KeyCode.E))
        {
            pickUpTarget.transform.position = target;
            pickUpTarget.transform.parent = Hand.transform;
            PickedUp = true;
            //pickUpTarget.position = target;
            //pickUpTarget.transform.parent = Item;

        }

        if (PickedUp == true && Input.GetKey(KeyCode.Q))
        {
            pickUpTarget.transform.parent = null;
            PickedUp = false;
        }   
        

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CanPickUp"))
        {
            CanPickUp = true;
            pickUpTarget = other.gameObject;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CanPickUp = false;
        pickUpTarget = null;
        
    }

   
}
