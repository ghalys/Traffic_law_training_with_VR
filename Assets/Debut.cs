using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Debut : MonoBehaviour
{
    public GameObject StartPannel ;
    public GameObject carcomponent;
    public PauseManager pause_manager;
    public String msg_debut = "";
    public TextMeshProUGUI txt;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        carcomponent.SetActive(false);
        
        txt.text = msg_debut;

    }
    
    public void commencer() {
        StartPannel.SetActive(false) ;
        pause_manager.ModeMenu(false);
    }
    
}
