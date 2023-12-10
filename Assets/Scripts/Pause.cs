using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseObjet;
    public GameObject Parametres;
    public GameObject Sure;
    public bool isPaused ;

    // Start is called before the first frame update
    void Start()
    {
        isPaused = true;
        PauseObjet.SetActive(true) ;
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void Reprendre()
    {
        PauseObjet.SetActive(false);
        //ajouter une script pour passer à la scene du jeu 
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void GoToMainMenu()
    {
        // Désactive le panneau actuel (pause)
        PauseObjet.SetActive(false);

        // Active le panneau du menu principal
        Sure.SetActive(true);

    }
    public void GoToParameters()
    {
       PauseObjet.SetActive(false);
       Parametres.SetActive(true) ; 
    }



}
