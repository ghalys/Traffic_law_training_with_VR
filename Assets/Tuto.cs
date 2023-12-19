using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto : MonoBehaviour
{
    public GameObject TutoPannel ;
    public Transform player;
    public GameObject carcomponent;
    public bool show_tuto ;

    public float spawnDistance = 2 ;

    public float hauteur = 2 ; 
    public   GameObject debut ;
    public bool change = false;

    void Start()
    {
        show_tuto = GameManager.showTuto;
        if(show_tuto){
        Time.timeScale = 0;
        carcomponent.SetActive(false);
        // TutoPannel.transform.LookAt(player.transform.position);
        // TutoPannel.transform.position = player.position + player.forward * spawnDistance + new Vector3(0, hauteur, 0);
        // TutoPannel.transform.Rotate(0, 180, 0);
        TutoPannel.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
      TutoPannel.transform.LookAt(new Vector3(2 * TutoPannel.transform.position.x - player.position.x, TutoPannel.transform.position.y, 2 * TutoPannel.transform.position.z - player.position.z));                   
            
        }
        else{
            TutoPannel.SetActive(false) ;        
            debut.SetActive(true);
        }

    }
    public void dontShow() {
        GameManager.showTuto = false;
    }

    public void passer() {
        TutoPannel.SetActive(false) ;
        debut.SetActive(true) ;
    }
}
