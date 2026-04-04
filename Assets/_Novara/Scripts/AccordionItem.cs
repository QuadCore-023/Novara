using UnityEngine;
using UnityEngine.UI;

public class AccordionItem : MonoBehaviour
{
    [Header("UI References")]
    public GameObject bodyObject; // Drag your Obj_Body here
    public RectTransform arrowIcon; // Optional: Drag an arrow icon here to rotate it

    private bool isOpen = false;

    private void Start()
    {
        // Ensure it starts closed
        if (bodyObject != null)
            bodyObject.SetActive(false);
    }

    public void ToggleAccordion()
    {
        isOpen = !isOpen;

        // Toggle the body
        if (bodyObject != null)
            bodyObject.SetActive(isOpen);

        // Optional: Rotate arrow (0 degrees if closed, 180 if open)
        if (arrowIcon != null)
            arrowIcon.localRotation = Quaternion.Euler(0, 0, isOpen ? 180 : 0);
    }
}