using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;


public class selectionObjet : MonoBehaviour
{
    public Transform[] ob;
    public GameObject[] obs;
    public Transform[] positions;
    public int num1;
    public int num2;
    public int num3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void choix()
    {
        choixaleatoire();
        ob[num1].DOMove(positions[0].position, 1);
        ob[num2].DOMove(positions[1].position, 1);
        ob[num3].DOMove(positions[2].position, 1);
        obs[num1].SetActive(true);
        obs[num2].SetActive(true);
        obs[num3].SetActive(true);
    }
    void choixaleatoire()
    {
        num1 = Random.Range(0,ob.Length);
        num2 = Random.Range(0,ob.Length);
        num3 = Random.Range(0,ob.Length);
        while(num2 == num1)
        {
            num2 = Random.Range(0,ob.Length);
        }
        while(num3 == num1 || num3 == num2)
        {
            num3 = Random.Range(0,ob.Length);
        }
    }
}
