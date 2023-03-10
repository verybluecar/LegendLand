using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    public TMP_Text textComponent;
    public int numberToAdd = 1;

    private void Start()
    {
        // Set the default text on the text component
        textComponent.text = "0";
    }

    public void OnButtonPress()
    {
        // Get the current value of the text and parse it as an integer
        int currentValue = int.Parse(textComponent.text);

        // Add the number to the current value
        int newValue = currentValue + numberToAdd;

        // Update the text component with the new value
        textComponent.text = newValue.ToString();
    }
}



