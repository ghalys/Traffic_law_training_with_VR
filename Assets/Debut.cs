using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debut : MonoBehaviour
{
    public GameObject StartPannel ;
    public Transform player;
    public GameObject carcomponent;
    public PauseManager pause_manager;
    public float spawnDistance = 2 ;

    public float hauteur = 2 ;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        carcomponent.SetActive(false);
        StartPannel.transform.LookAt(player.transform.position);
        StartPannel.transform.position = player.position + player.forward * spawnDistance + new Vector3(0, hauteur,0);
        StartPannel.transform.Rotate(0, 180, 0);
    }

    public void commencer() {
        StartPannel.SetActive(false) ;
        pause_manager.ModeMenu(false);
    }
    
}
