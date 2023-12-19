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
    public void SetMessageSpeed(){
      txt.text = "Attention, la vitesse maximale autorisée en ville est de 60km/h";
    } 
    public void SetMessageNoLeftSignal(){
      txt.text = "Vous n'avez pas activé le clignotant. Rappel, le clignotant se trouve sur la gachette latérale du controlleur";
    }
    public void SetMessageCollisionRobotEtPriorite(){
      txt.text = "Accident... Vous n'avez pas respecté la priorité à droite";
    } 
    public void SetMessageCollision(String name){
      txt.text = "Attention, vous avez touché "+ name;
    }
    public void SetMessagepassage_pieton(){
      txt.text = "Attention, vous devez laisser la priorité aux piétons";
    }
    public void SetMessageExitedRoad(){
      txt.text = "Attention, vous êtes sorti des limites du jeu. Veuillez relire la consigne du début";
    }
    public void SetMessagePriorite_ADroite(){
      txt.text = "Vous n'avez pas respecté la règle de la priorité à droite";
    }
    


    
}
