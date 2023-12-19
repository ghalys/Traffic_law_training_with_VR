using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bravo : MonoBehaviour
{

    public GameObject BravoPanel ; 
    public GameObject Situations ;
    public PauseManager pauseManager;
    

    void Start()
    {
        pauseManager.ModeMenu(true);
    }
    


    public void Quitter(){
        SceneManager.LoadScene("debut"); 
    }

    public void SituationSuivante(){
        if (GameManager.modeLibre){

            GameManager.scene_suivante();
        }
        else{
            Situations.SetActive(true);
            BravoPanel.SetActive(false);
        }

    }
}
