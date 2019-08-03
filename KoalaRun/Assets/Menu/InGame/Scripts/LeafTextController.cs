using UnityEngine;
using TMPro;

public class LeafTextController : MonoBehaviour
{
    public GameObject leafText;
    private static TextMeshProUGUI leafAmount;
    private void Start()
    {
        leafAmount = leafText.GetComponent<TextMeshProUGUI>();
    }
    public static void updateLeavesText()
    {
        leafAmount.text = PlayerAttributeController.Leaves.ToString() + " X ";
    }
}
