using UnityEngine;

public class testvoircouleur : MonoBehaviour
{
    public bool taliseman;
    public bool gemme;
    public GameObject image;
    void Start()
    {
        taliseman = false;
        gemme = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.V))
        {
            verrifier();
        }
    }

    public void taltrue()
    {
        taliseman = true;
    }
    public void talfalse()
    {
        taliseman = false;
    }
    public void gemmetrue()
    {
        gemme = true;
    }
    public void gemmefalse()
    {
        gemme = false ;
    }



    public void verrifier()
    {
        if (taliseman && gemme)
        {

        }
        else
        {
            image.SetActive(true);
        }   
    } 
}
