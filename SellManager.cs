using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SellManager : MonoBehaviour
{
    public int SellingAmount = 0;
    public int PumpkinPrice;

    public TextMeshProUGUI amountText;
    public TextMeshProUGUI PriceText;

    public Button SubtractButton;
    public Button AddButton;

    void Start()
    {
        
    }
    void Update()
    {
        amountText.text = "" + SellingAmount;
        PriceText.text = "" + PumpkinPrice +" x";

        if (SellingAmount <= 0)
        {
            SellingAmount = 0;
        }

        if (SellingAmount <= GameManager.instance.pumpkins - 1)
        {
            AddButton.interactable = true;
        }
        else
        {
            AddButton.interactable = false;
        }

        
    }

    public void Add()
    {
        if (SellingAmount <= GameManager.instance.pumpkins - 1)
        {
            SellingAmount++;
        }
        else
        {
            AddButton.interactable = false;
        }
    }
    public void Subtract()
    {
        if (SellingAmount >= 0)
        {
            SellingAmount--;
        }
        else
        {
            SubtractButton.interactable = false;
        }
    }

    public void Sell()
    {
        GameManager.instance.money += SellingAmount * PumpkinPrice;

        GameManager.instance.pumpkins -= SellingAmount;

        SellingAmount = 0;
    }


}
