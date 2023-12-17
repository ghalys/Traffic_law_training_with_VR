using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailMenu : MonoBehaviour
{

    public GameObject FailedM ; 

    public Transform player;

    public float spawnDistance = 2 ;
    public float hauteur = 2 ;

    public bool ispaused=true ;
    public TextMeshProUGUI txt;

    

    [Header("Objects to Hide")]
    public GameObject Carcomponents ;
    
    // Start is called before the first frame update
    void Start()
    {
      FailedM.SetActive(true) ;  
      ispaused = true;
      Time.timeScale = 0;
      FailedM.transform.LookAt(player.transform.position);
      FailedM.transform.position = player.position + player.forward * spawnDistance + new Vector3(0, hauteur,0);
      FailedM.transform.Rotate(0, 180, 0);
      Carcomponents.SetActive(false) ;
    }

    public void SetMessageCollisionRobot(){
      txt.text = "Accident, Game over";
    }
    public void SetMessagePriorite_ADroite(){
      txt.text = "Vous n'avez pas respecté la règle de la priorité à droite";
    }
    
    public void QuitterF(){
        SceneManager.LoadScene("debut"); 

    }
    public void Recommencer(){
             SceneManager.LoadScene("PrioritéV2"); 
   
    }
}
