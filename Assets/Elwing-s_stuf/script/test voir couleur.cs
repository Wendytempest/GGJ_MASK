using UnityEngine;
using UnityEngine.SceneManagement;

public class testvoircouleur : MonoBehaviour
{
    public GameObject objet;
    public Color rouge;
    public Color vert;
    public Color bleu;
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
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 
}
