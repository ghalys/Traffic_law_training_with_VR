using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Situations;
    public GameObject Parametres ;

    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    { 
       // SceneManager.LoadScene(sceneName);
    }

    public void GoParameter() 
    {
        Menu.SetActive(false) ;
        Parametres.SetActive(true) ;
    }

    public void GoSituations()
    {
        Menu.SetActive(false) ;
        Situations.SetActive(true) ;
    }

    public void Quitter()
    {
        Application.Quit();
        
    }
}
