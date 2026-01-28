using UnityEngine;

public class testvoircouleur : MonoBehaviour
{
    public GameObject objet;
    public Color rouge;
    public GameObject image;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void verrifier()
    {
        if(objet.GetComponent<Renderer>().material.color !=rouge )
        
        {
            image.SetActive(true);
        }
    } 
}
