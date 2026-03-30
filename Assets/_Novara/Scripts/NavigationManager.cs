using UnityEngine;
using TMPro; // Needed for TextMeshPro
using UnityEngine.UI;

public class NavigationManager : MonoBehaviour
{
    [Header("UI References")]
    public TMP_Text button1Text;
    public TMP_Text button2Text;
    public TMP_Text button3Text;
    public TMP_Text button4Text;

    void Start()
    {
        // Start in the Bedroom by default
        SetBedroomLayout();
    }

    public void SetBedroomLayout()
    {
        button1Text.text = "Bed";
        button2Text.text = "Closet";
        button3Text.text = "Mirror";
        button4Text.text = "Phone"; // 4th is always Phone
    }

    public void SetKitchenLayout()
    {
        button1Text.text = "Fridge";
        button2Text.text = "Stove";
        button3Text.text = "Table";
        button4Text.text = "Phone";
    }

    // You can add more rooms like LivingRoom, Bathroom, etc. here!
}