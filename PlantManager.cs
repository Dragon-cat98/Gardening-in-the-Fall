using System.Collections;
using UnityEngine;

public class PlantManager : MonoBehaviour
{
    public Transform[] plantPosition;
    public Sprite PlantObject;
    public Sprite RootsObject;
    public GameObject[] SproutObject;
    public GameObject[] ClonedSprout;
    public GameObject[] RootsRemovingButton;
    public GameObject[] HarvestButton;

    public int plant_price = 5;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RootsRemovingButton[0].SetActive(false);
        HarvestButton[0].SetActive(false);

        RootsRemovingButton[1].SetActive(false);
        HarvestButton[1].SetActive(false);

        RootsRemovingButton[2].SetActive(false);
        HarvestButton[2].SetActive(false);

        RootsRemovingButton[3].SetActive(false);
        HarvestButton[3].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Plant()
    {
        ClonedSprout[0] = Instantiate(SproutObject[0], plantPosition[0]);
        GameManager.instance.isPlanted[0] = true;
        StartCoroutine(SproutingTimer(Random.Range(10f, 20f)));

        GameManager.instance.seeds--;
    }

    public void Plant2()
    {
        ClonedSprout[1] = Instantiate(SproutObject[0], plantPosition[1]);
        GameManager.instance.isPlanted[1] = true;
        StartCoroutine(SproutingTimer2(Random.Range(10f, 20f)));

        GameManager.instance.seeds--;
    }

    public void Plant3()
    {
        ClonedSprout[2] = Instantiate(SproutObject[0], plantPosition[2]);
        GameManager.instance.isPlanted[2] = true;
        StartCoroutine(SproutingTimer3(Random.Range(10f, 20f)));

        GameManager.instance.seeds--;
    }

    public void Plant4()
    {
        ClonedSprout[3] = Instantiate(SproutObject[0], plantPosition[3]);
        GameManager.instance.isPlanted[3] = true;
        StartCoroutine(SproutingTimer4(Random.Range(10f, 20f)));

        GameManager.instance.seeds--;
    }

    public void Harvest()
    {
        GameManager.instance.pumpkins += Random.Range(1, 5);
        ClonedSprout[0].GetComponent<SpriteRenderer>().sprite = RootsObject;
        HarvestButton[0].SetActive(false);
        ClonedSprout[0].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        RootsRemovingButton[0].SetActive(true);
    }
    public void Harvest2()
    {
        GameManager.instance.pumpkins += Random.Range(1, 5);

        ClonedSprout[1].GetComponent<SpriteRenderer>().sprite = RootsObject;
        HarvestButton[1].SetActive(false);
        ClonedSprout[1].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        RootsRemovingButton[1].SetActive(true);
    }
    public void Harvest3()
    {
        GameManager.instance.pumpkins += Random.Range(1, 5);

        ClonedSprout[2].GetComponent<SpriteRenderer>().sprite = RootsObject;
        HarvestButton[2].SetActive(false);
        ClonedSprout[2].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        RootsRemovingButton[2].SetActive(true);
    }
    public void Harvest4()
    {
        GameManager.instance.pumpkins += Random.Range(1, 5);

        ClonedSprout[3].GetComponent<SpriteRenderer>().sprite = RootsObject;
        HarvestButton[3].SetActive(false);
        ClonedSprout[3].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        RootsRemovingButton[3].SetActive(true);
    }

    public void removeRoots()
    {
        //GameManager.instance.money -= Random.Range(0, 8);

        Destroy(ClonedSprout[0]);
        GameManager.instance.isPlanted[0] = false;
        RootsRemovingButton[0].SetActive(false);

    }
    public void removeRoots2()
    {
        //GameManager.instance.money -= Random.Range(0, 8);

        Destroy(ClonedSprout[1]);
        GameManager.instance.isPlanted[1] = false;
        RootsRemovingButton[1].SetActive(false);

    }
    public void removeRoots3()
    {
        //GameManager.instance.money -= Random.Range(0, 8);

        Destroy(ClonedSprout[2]);
        GameManager.instance.isPlanted[2] = false;
        RootsRemovingButton[2].SetActive(false);

    }
    public void removeRoots4()
    {
        //GameManager.instance.money -= Random.Range(0, 8);

        Destroy(ClonedSprout[3]);
        GameManager.instance.isPlanted[3] = false;
        RootsRemovingButton[3].SetActive(false);

    }



    public IEnumerator SproutingTimer(float time)
    {
        yield return new WaitForSeconds(time);
        ClonedSprout[0].transform.localScale = new Vector3(1f, 1f, 1f);

        Destroy(ClonedSprout[0].transform.GetChild(0).gameObject);

        ClonedSprout[0].GetComponent<SpriteRenderer>().sprite = PlantObject;

        HarvestButton[0].SetActive(true);
    }

    public IEnumerator SproutingTimer2(float time)
    {
        yield return new WaitForSeconds(time);
        ClonedSprout[1].transform.localScale = new Vector3(1f, 1f, 1f);

        Destroy(ClonedSprout[1].transform.GetChild(0).gameObject);

        ClonedSprout[1].GetComponent<SpriteRenderer>().sprite = PlantObject;

        HarvestButton[1].SetActive(true);

    }

    public IEnumerator SproutingTimer3(float time)
    {
        yield return new WaitForSeconds(time);
        ClonedSprout[2].transform.localScale = new Vector3(1f, 1f, 1f);

        Destroy(ClonedSprout[2].transform.GetChild(0).gameObject);

        ClonedSprout[2].GetComponent<SpriteRenderer>().sprite = PlantObject;

        HarvestButton[2].SetActive(true);

    }

    public IEnumerator SproutingTimer4(float time)
    {
        yield return new WaitForSeconds(time);
        ClonedSprout[3].transform.localScale = new Vector3(1f, 1f, 1f);

        Destroy(ClonedSprout[3].transform.GetChild(0).gameObject);

        ClonedSprout[3].GetComponent<SpriteRenderer>().sprite = PlantObject;

        HarvestButton[3].SetActive(true);

    }
}
