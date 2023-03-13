
using UnityEngine;
using System.Collections;

public class BarbellController : MonoBehaviour
{
    public float pickupRange = 2f;
    public Transform pickupDestination;
    private bool isHoldingBarbell = false;
    private Transform heldBarbell;

    private void OnTriggerEnter(Collider other)
    {
        if (!isHoldingBarbell && other.CompareTag("Barbell"))
        {
            heldBarbell = other.transform;
            heldBarbell.GetComponent<Rigidbody>().isKinematic = true;
            heldBarbell.position = pickupDestination.position;
            heldBarbell.parent = pickupDestination;
            isHoldingBarbell = true;
        }
    }

}

