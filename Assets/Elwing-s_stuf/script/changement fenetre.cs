using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changementfenetre : MonoBehaviour
{
    public string jeu; 
    public GameObject gameover;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
