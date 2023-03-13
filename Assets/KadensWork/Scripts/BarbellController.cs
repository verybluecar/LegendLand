using UnityEngine;

public class BarbellController : MonoBehaviour
{
    // Variables to store the positions of the barbell when it is picked up or dropped
    private Vector3 pickupPosition;
    private Vector3 dropPosition;

    // Boolean to track whether the barbell is currently being held by the player
    private bool isHeld = false;

    // Reference to the player object
    public GameObject player;

    // Distance from the player at which the barbell will be held
    public float holdDistance = 2f;

    // Empty transform to represent the target position for the barbell
    public Transform targetTransform;

    // Method to be called when the barbell enters a trigger collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Store the current position of the barbell and the position it should be held at
            pickupPosition = transform.position;
            dropPosition = player.transform.position + (player.transform.forward * holdDistance);

            // Set the parent of the barbell to the player object and move it to the hold position
            transform.SetParent(player.transform);
            transform.position = dropPosition;

            // Move the barbell to the target position
            transform.position = targetTransform.position;

            // Set the isHeld flag to true
            isHeld = true;
        }
    }

    // Method to be called when the E key is pressed while the barbell is being held
    private void DropBarbell()
    {
        // Set the parent of the barbell back to the default (null) and move it to the original position
        transform.SetParent(null);
        transform.position = pickupPosition;

        // Set the isHeld flag to false
        isHeld = false;
    }

    // Update is called once per frame
    void Update()
    {
        // If the barbell is being held and the E key is pressed, drop it
        if (isHeld && Input.GetKeyDown(KeyCode.E))
        {
            DropBarbell();
        }
    }
}








