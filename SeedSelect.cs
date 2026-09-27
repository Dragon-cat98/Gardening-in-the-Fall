using UnityEngine;
using UnityEngine.UI;

public class SeedSelect : MonoBehaviour
{
    public Button PumpkinSelectButton;
    public Button StrawberrySelectButton;
    public void SelectPumpkin()
    {
        GameManager.instance.isSelected_pumpkin = true;
        GameManager.instance.isSelected_strawberry = false;
        PumpkinSelectButton.interactable = false;
        StrawberrySelectButton.interactable = true;
    }

    public void SelectStrawberry()
    {
        GameManager.instance.isSelected_strawberry = true;
        GameManager.instance.isSelected_pumpkin = false;
        StrawberrySelectButton.interactable = false;
        PumpkinSelectButton.interactable = true;
    }
}
