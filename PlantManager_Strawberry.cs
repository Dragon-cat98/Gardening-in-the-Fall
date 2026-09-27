using System.Collections;
using UnityEngine;

public class PlantManager_Strawberry : MonoBehaviour
{
    public Transform[] plantPosition;
    public Sprite PlantObject_Strawberry;
    public Sprite RootsObject_Strawberry;
    public GameObject[] SproutObject_Strawberry;
    public GameObject[] ClonedSprout_Strawberry;
    public GameObject[] RootsRemovingButton_Strawberry;
    public GameObject[] HarvestButton_Strawberry;

    public int plant_price_Strawberry = 5;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RootsRemovingButton_Strawberry[0].SetActive(false);
        HarvestButton_Strawberry[0].SetActive(false);

        RootsRemovingButton_Strawberry[1].SetActive(false);
        HarvestButton_Strawberry[1].SetActive(false);

        RootsRemovingButton_Strawberry[2].SetActive(false);
        HarvestButton_Strawberry[2].SetActive(false);

        RootsRemovingButton_Strawberry[3].SetActive(false);
        HarvestButton_Strawberry[3].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Plant()
    {
        ClonedSprout_Strawberry[0] = Instantiate(SproutObject_Strawberry[0], plantPosition[0]);
        GameManager.instance.isPlanted_Strawberry[0] = true;
        StartCoroutine(SproutingTimer(Random.Range(20f, 40f)));

        GameManager.instance.seeds_strawberry--;
    }

    public void Plant2()
    {
        ClonedSprout_Strawberry[1] = Instantiate(SproutObject_Strawberry[0], plantPosition[1]);
        GameManager.instance.isPlanted_Strawberry[1] = true;
        StartCoroutine(SproutingTimer2(Random.Range(20f, 40f)));

        GameManager.instance.seeds_strawberry--;
    }

    public void Plant3()
    {
        ClonedSprout_Strawberry[2] = Instantiate(SproutObject_Strawberry[0], plantPosition[2]);
        GameManager.instance.isPlanted_Strawberry[2] = true;
        StartCoroutine(SproutingTimer3(Random.Range(20f, 40f)));

        GameManager.instance.seeds_strawberry--;
    }

    public void Plant4()
    {
        ClonedSprout_Strawberry[3] = Instantiate(SproutObject_Strawberry[0], plantPosition[3]);
        GameManager.instance.isPlanted_Strawberry[3] = true;
        StartCoroutine(SproutingTimer4(Random.Range(20f, 40f)));

        GameManager.instance.seeds_strawberry--;
    }

    public void Harvest()
    {
        GameManager.instance.money += Random.Range(12, 36);
        ClonedSprout_Strawberry[0].GetComponent<SpriteRenderer>().sprite = RootsObject_Strawberry;
        HarvestButton_Strawberry[0].SetActive(false);
        ClonedSprout_Strawberry[0].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        RootsRemovingButton_Strawberry[0].SetActive(true);
    }
    public void Harvest2()
    {
        GameManager.instance.money += Random.Range(12, 36);

        ClonedSprout_Strawberry[1].GetComponent<SpriteRenderer>().sprite = RootsObject_Strawberry;
        HarvestButton_Strawberry[1].SetActive(false);
        ClonedSprout_Strawberry[1].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        RootsRemovingButton_Strawberry[1].SetActive(true);
    }
    public void Harvest3()
    {
        GameManager.instance.money += Random.Range(12, 36);

        ClonedSprout_Strawberry[2].GetComponent<SpriteRenderer>().sprite = RootsObject_Strawberry   ;
        HarvestButton_Strawberry[2].SetActive(false);
        ClonedSprout_Strawberry[2].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        RootsRemovingButton_Strawberry[2].SetActive(true);
    }
    public void Harvest4()
    {
        GameManager.instance.money += Random.Range(12, 36);

        ClonedSprout_Strawberry[3].GetComponent<SpriteRenderer>().sprite = RootsObject_Strawberry;
        HarvestButton_Strawberry[3].SetActive(false);
        ClonedSprout_Strawberry[3].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        RootsRemovingButton_Strawberry[3].SetActive(true);
    }

    public void removeRoots()
    {
        GameManager.instance.money -= Random.Range(0, 5);

        Destroy(ClonedSprout_Strawberry[0]);
        GameManager.instance.isPlanted_Strawberry[0] = false;
        RootsRemovingButton_Strawberry[0].SetActive(false);

    }
    public void removeRoots2()
    {
        GameManager.instance.money -= Random.Range(0, 5);

        Destroy(ClonedSprout_Strawberry[1]);
        GameManager.instance.isPlanted_Strawberry[1] = false;
        RootsRemovingButton_Strawberry[1].SetActive(false);

    }
    public void removeRoots3()
    {
        GameManager.instance.money -= Random.Range(0, 5);

        Destroy(ClonedSprout_Strawberry[2]);
        GameManager.instance.isPlanted_Strawberry[2] = false;
        RootsRemovingButton_Strawberry[2].SetActive(false);

    }
    public void removeRoots4()
    {
        GameManager.instance.money -= Random.Range(0, 5);

        Destroy(ClonedSprout_Strawberry[3]);
        GameManager.instance.isPlanted_Strawberry[3] = false;
        RootsRemovingButton_Strawberry[3].SetActive(false);

    }



    public IEnumerator SproutingTimer(float time)
    {
        yield return new WaitForSeconds(time);
        ClonedSprout_Strawberry[0].transform.localScale = new Vector3(1f, 1f, 1f);

        Destroy(ClonedSprout_Strawberry[0].transform.GetChild(0).gameObject);

        ClonedSprout_Strawberry[0].GetComponent<SpriteRenderer>().sprite = PlantObject_Strawberry;

        HarvestButton_Strawberry[0].SetActive(true);
    }

    public IEnumerator SproutingTimer2(float time)
    {
        yield return new WaitForSeconds(time);
        ClonedSprout_Strawberry[1].transform.localScale = new Vector3(1f, 1f, 1f);

        Destroy(ClonedSprout_Strawberry[1].transform.GetChild(0).gameObject);

        ClonedSprout_Strawberry[1].GetComponent<SpriteRenderer>().sprite = PlantObject_Strawberry;

        HarvestButton_Strawberry[1].SetActive(true);

    }

    public IEnumerator SproutingTimer3(float time)
    {
        yield return new WaitForSeconds(time);
        ClonedSprout_Strawberry[2].transform.localScale = new Vector3(1f, 1f, 1f);

        Destroy(ClonedSprout_Strawberry[2].transform.GetChild(0).gameObject);

        ClonedSprout_Strawberry[2].GetComponent<SpriteRenderer>().sprite = PlantObject_Strawberry;

        HarvestButton_Strawberry[2].SetActive(true);

    }

    public IEnumerator SproutingTimer4(float time)
    {
        yield return new WaitForSeconds(time);
        ClonedSprout_Strawberry[3].transform.localScale = new Vector3(1f, 1f, 1f);

        Destroy(ClonedSprout_Strawberry[3].transform.GetChild(0).gameObject);

        ClonedSprout_Strawberry[3].GetComponent<SpriteRenderer>().sprite = PlantObject_Strawberry;

        HarvestButton_Strawberry[3].SetActive(true);

    }
}
