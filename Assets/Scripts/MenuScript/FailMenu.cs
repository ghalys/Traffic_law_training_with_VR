using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailMenu : MonoBehaviour
{

    public GameObject FailedM ; 


    public TextMeshProUGUI txt;
    public PauseManager pauseManager;

    
    void Start()
    {
      FailedM.SetActive(true) ;  
      
      pauseManager.ModeMenu(true);
    }

    public void SetMessageCollisionRobot(){
      txt.text = "Accident...";
    } 
    public void SetMessageCollisionRobotEtPriorite(){
      txt.text = "Accident... Vous n'avez pas respecté la priorité à droite";
    } 
    public void SetMessageCollision(String name){
      txt.text = "Attention, vous avez touché "+ name;
    }
    public void SetMessageExitedRoad(){
      txt.text = "Attention, vous êtes sorti des limites du jeu. Veuillez relire la consigne du début";
    }
    public void SetMessagePriorite_ADroite(){
      txt.text = "Vous n'avez pas respecté la règle de la priorité à droite";
    }
    


    
}
