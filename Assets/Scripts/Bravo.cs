using System.Collections;
using System.Collections.Generic;
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
        Time.timeScale = 0;
        BravoPanel.transform.LookAt(player.transform.position);
        BravoPanel.transform.position = player.position + player.forward * spawnDistance + new Vector3(0, hauteur, 0);
        BravoPanel.transform.Rotate(0, 180, 0);
        pauseManager.ModeMenu(true);

    }
    
    public void Recommencer()
    {
        SceneManager.LoadScene("PrioritéV2"); 
    }


    public void Quitter(){
        SceneManager.LoadScene("debut"); 
    }

    public void Menu_principal(){
        SceneManager.LoadScene("debut");

    }
}
