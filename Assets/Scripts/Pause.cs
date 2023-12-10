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

     public GameObject body ;

    public GameObject components ;
    public GameObject Board ;

    public GameObject wheel1 ;
    public GameObject wheel2 ;

    public GameObject wheel3 ;

    public GameObject wheel4 ;

    public GameObject Origin ;
    public GameObject Rig ;

    

    // Start is called before the first frame update
    void Start()
    {
        ispaused = true;
        PauseObjet.SetActive(true) ;
        
    }

    // Update is called once per frame
    void Update()
    {


    }



    public void Recommencer()
    {
        SceneManager.LoadScene("PrioritéV2"); 
        //ajouter une script pour passer à la scene du jeu 
    }

    public void Reprendre()
    {
        PauseObjet.SetActive(false);
        ispaused = false;
        Time.timeScale = 1;
        wheel1.SetActive(true) ;
        wheel2.SetActive(true) ;
        wheel3.SetActive(true) ;
        wheel4.SetActive(true) ;
        body.SetActive(true) ;
        components.SetActive(true) ;
        Board.SetActive(true) ;
        Origin.SetActive(false) ;
        Rig.SetActive(true) ;
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
