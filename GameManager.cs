using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool[] isPlanted;
    public bool[] isPlanted_Strawberry;

    public GameObject[] PlantButton;
    public GameObject[] PlantButton_Strawberry;

    public int money;
    public int pumpkins = 0;
    public int seeds = 4;
    public int seeds_strawberry = 4;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI seedsText;
    public TextMeshProUGUI seedsText_Strawberry;
    public TextMeshProUGUI pumpkinsAmount_text;

    public bool isSelected_pumpkin = true;
    public bool isSelected_strawberry = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "money: " + money;
        seedsText.text = "" + seeds;
        seedsText_Strawberry.text = "" + seeds_strawberry;

        pumpkinsAmount_text.text = "pumpkins: " + pumpkins;

        if (seeds <= 0 /*&& isSelected_pumpkin == false && isSelected_strawberry == true*/)
        {
            PlantButton[0].SetActive(false);
            PlantButton[1].SetActive(false);
            PlantButton[2].SetActive(false);
            PlantButton[3].SetActive(false);
        }
        else if (seeds > 0 /*&& isSelected_pumpkin == true && isSelected_strawberry == false*/)
        {
            if (isPlanted[0] == false)
            {
                PlantButton[0].SetActive(true);

            }
            else
            {
                PlantButton[0].SetActive(false);
            }


            if (isPlanted[1] == false)
            {
                PlantButton[1].SetActive(true);

            }
            else
            {
                PlantButton[1].SetActive(false);
            }


            if (isPlanted[2] == false)
            {
                PlantButton[2].SetActive(true);

            }
            else
            {
                PlantButton[2].SetActive(false);
            }


            if (isPlanted[3] == false)
            {
                PlantButton[3].SetActive(true);

            }
            else
            {
                PlantButton[3].SetActive(false);
            }
        }

        if (seeds_strawberry <= 0 /*&& isSelected_strawberry == false && isSelected_pumpkin == true*/)
        {
            PlantButton_Strawberry[0].SetActive(false);
            PlantButton_Strawberry[1].SetActive(false);
            PlantButton_Strawberry[2].SetActive(false);
            PlantButton_Strawberry[3].SetActive(false);
        }
        else if (seeds_strawberry > 0 /*&& isSelected_strawberry == true && isSelected_pumpkin == false*/)
        {
            if (isPlanted_Strawberry[0] == false)
            {
                PlantButton_Strawberry[0].SetActive(true);

            }
            else
            {
                PlantButton_Strawberry[0].SetActive(false);
            }


            if (isPlanted_Strawberry[1] == false)
            {
                PlantButton_Strawberry[1].SetActive(true);

            }
            else
            {
                PlantButton_Strawberry[1].SetActive(false);
            }


            if (isPlanted_Strawberry[2] == false)
            {
                PlantButton_Strawberry[2].SetActive(true);

            }
            else
            {
                PlantButton_Strawberry[2].SetActive(false);
            }


            if (isPlanted_Strawberry[3] == false)
            {
                PlantButton_Strawberry[3].SetActive(true);

            }
            else
            {
                PlantButton_Strawberry[3].SetActive(false);
            }
        }

    }
}
