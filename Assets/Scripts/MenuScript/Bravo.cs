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
    


    public Transform player;

    public float spawnDistance = 2 ;
    public float hauteur = 2 ; 
    public bool change = false;

    void Start()
    {
        // BravoPanel.transform.LookAt(player.transform.position);
        // BravoPanel.transform.position = player.position + player.forward * spawnDistance + new Vector3(0, hauteur, 0);
        // BravoPanel.transform.Rotate(0, 180, 0);
        pauseManager.ModeMenu(true);
        BravoPanel.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
      BravoPanel.transform.LookAt(new Vector3(2 * BravoPanel.transform.position.x - player.position.x, BravoPanel.transform.position.y, 2 * BravoPanel.transform.position.z - player.position.z));                   
            

    }
    


    public void Quitter(){
        SceneManager.LoadScene("debut"); 
    }

    public void SituationSuivante(){
        if (GameManager.modeLibre){

            GameManager.scene_suivante();
        }
        else{
            SceneManager.LoadScene("debut");
        }

    }
}
