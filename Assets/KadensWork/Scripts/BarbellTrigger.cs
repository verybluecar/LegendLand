using UnityEngine;
using UnityEngine.UI;

public class BarbellTrigger : MonoBehaviour
{
    public GameObject canvas;
    private PlayerController playerController;

    private void Start()
    {
        canvas.SetActive(false);
        playerController = GetComponent<PlayerController>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(true);
            

        }
    }
    
    public void cannychange()
    {
        canvas.SetActive(false);
    }
}

