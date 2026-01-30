using UnityEngine;
using UnityEngine.SceneManagement;

public class testvoircouleur : MonoBehaviour
{
    public GameObject taliseman;
    public GameObject gemme;
    public Color rouge;
    public Color vert;
    public Color bleu;
    public GameObject image;
    public string jeu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.V))
        {
            verrifier();
            print(bleu);
            print(gemme.GetComponent<Renderer>().material.color);
            print(rouge);
            print(taliseman.GetComponent<Renderer>().material.color);
        }
    }

    public void verrifier()
    {
        if(taliseman.GetComponent<Renderer>().material.color !=rouge && gemme.GetComponent<Renderer>().material.color !=bleu )
        
        {
            image.SetActive(true);
        }
        else
        {
            print(bleu);
        }   
    } 
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 
    public void LoadLevel()
    {          
        SceneManager.LoadSceneAsync(jeu);
    }
    public void quitter()
    {
        Application.Quit();
    }
}
