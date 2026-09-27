using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopScript : MonoBehaviour
{
    public int seedsAmount;
    public int price;
    public Button BuyButton;

    public bool canBuy;

    public TextMeshProUGUI priceText;

    public void buySeeds()
    {
        GameManager.instance.money -= price;
        GameManager.instance.seeds += seedsAmount;
    }

    void Update()
    {
        priceText.text = "" + price;

        if (GameManager.instance.money >= price)
        {
            canBuy = true;

        }
        else
        {
            canBuy = false;
        }

        if (canBuy == true)
        {
            BuyButton.interactable = true;
        }
        else
        {
            BuyButton.interactable = false;
        }
    }
}
