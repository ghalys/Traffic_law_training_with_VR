using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto : MonoBehaviour
{
    public GameObject TutoPannel ;
    public Transform player;

    public float spawnDistance = 2 ;

    public float hauteur = 2 ;   
    public   GameObject debut ;
    // Start is called before the first frame update
    void Start()
    {
        
        //TutoPannel.SetActive(true) ;
        TutoPannel.transform.LookAt(new Vector3(2 * TutoPannel.transform.position.x - player.position.x, TutoPannel.transform.position.y, 2 * TutoPannel.transform.position.z - player.position.z)); 
        TutoPannel.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void passer() {
        TutoPannel.SetActive(false) ;
        debut.SetActive(true) ;

    }
}
