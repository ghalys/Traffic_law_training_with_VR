using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto : MonoBehaviour
{
    public GameObject TutoPannel ;
    public Transform player;
    public GameObject carcomponent;

    public float spawnDistance = 2 ;

    public float hauteur = 2 ;   
    public   GameObject debut ;
    public bool change = false;
    // Start is called before the first frame update
    void Start()
    {
        // Time.timeScale = 0;

        // carcomponent.SetActive(false);
        
        //TutoPannel.SetActive(true) ;
        // TutoPannel.transform.LookAt(new Vector3(2 * TutoPannel.transform.position.x - player.position.x, TutoPannel.transform.position.y, 2 * TutoPannel.transform.position.z - player.position.z)); 
        // TutoPannel.transform.LookAt(new Vector3(player.position.x, TutoPannel.transform.position.y, player.position.z));
        TutoPannel.transform.Rotate(0, 180, 0);

        // TutoPannel.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;  
        TutoPannel.transform.position = player.position + player.forward * spawnDistance + new Vector3(0, hauteur, 0);
        TutoPannel.transform.Rotate(Vector3.up, -30.0f);

    }


    public void passer() {
        TutoPannel.SetActive(false) ;
        debut.SetActive(false) ;
        Time.timeScale = 1;


    }
}
