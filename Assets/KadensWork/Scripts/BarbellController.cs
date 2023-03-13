using UnityEngine;
using System.Collections;

public class BarbellController : MonoBehaviour
{
    public float pickupRange = 2f;
    public Transform pickupDestination;
    public float moveSpeed = 1f;
    public float moveRange = 1f;
    private bool isHoldingBarbell = false;
    private Transform heldBarbell;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isHoldingBarbell)
            {
                // Start moving the barbell up and down
                StartCoroutine(MoveBarbell());
            }
        }
    }

    private IEnumerator MoveBarbell()
    {
        float startY = heldBarbell.position.y;
        float endY = startY + moveRange;
        float progress = 0f;

        while (progress < 1f)
        {
            progress += moveSpeed * Time.deltaTime;
            float newY = Mathf.Lerp(startY, endY, Mathf.PingPong(progress, 1f));
            heldBarbell.position = new Vector3(heldBarbell.position.x, newY, heldBarbell.position.z);
            yield return null;
        }
    }

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

    private void OnTriggerExit(Collider other)
    {
        if (isHoldingBarbell && other.transform == heldBarbell)
        {
            heldBarbell.parent = null;
            heldBarbell.GetComponent<Rigidbody>().isKinematic = false;
            heldBarbell = null;
            isHoldingBarbell = false;
        }
    }
}

