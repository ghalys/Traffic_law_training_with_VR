using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Debut : MonoBehaviour
{
    public GameObject StartPannel ;
    public Transform player;
    public GameObject carcomponent;
    public PauseManager pause_manager;
    public float spawnDistance = 2 ;
    public String msg_debut = "";
    public TextMeshProUGUI txt;
    public float hauteur = 2 ;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        carcomponent.SetActive(false);
        // StartPannel.transform.LookAt(player.transform.position);
        // StartPannel.transform.position = player.position + player.forward * spawnDistance + new Vector3(0, hauteur,0);
        // StartPannel.transform.Rotate(0, 180, 0);

         StartPannel.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
      StartPannel.transform.LookAt(new Vector3(2 * StartPannel.transform.position.x - player.position.x, StartPannel.transform.position.y, 2 * StartPannel.transform.position.z - player.position.z));                   
            
        txt.text = msg_debut;

    }
    

    public void commencer() {
        StartPannel.SetActive(false) ;
        pause_manager.ModeMenu(false);
    }
    
}
