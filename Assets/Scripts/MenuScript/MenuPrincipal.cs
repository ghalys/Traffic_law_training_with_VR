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
        GameManager.modeLibre = false;
    }
     public void GoModeLibre()
    {
        Menu.SetActive(false) ;
        GameManager.modeLibre = true;
        GameManager.index_situation = 0;
        GameManager.scene_suivante();
    }

    public void Quitter()
    {
        Application.Quit();
        
    }
}
