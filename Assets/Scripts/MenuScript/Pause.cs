using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public GameObject PauseObjet;
    public GameObject Parametres;
    public GameObject Sure;
    public bool ispaused ;
    public PauseManager pauseManager;
    

    // Start is called before the first frame update
    void Start()
    {
        ispaused = true;
        PauseObjet.SetActive(true) ;
        
    }



    public void Reprendre()
    {
        PauseObjet.SetActive(false);
        ispaused = false;
        pauseManager.ModeMenu(false);
           }

    public void Quitter()
    {
        Application.Quit();
    }

    public void GoToMainMenu()
    {
        PauseObjet.SetActive(false);
        Sure.SetActive(true);

    }
    public void GoToParameters()
    {
       PauseObjet.SetActive(false);
       Parametres.SetActive(true) ; 
    }



}
