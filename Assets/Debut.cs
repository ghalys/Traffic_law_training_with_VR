using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debut : MonoBehaviour
{
    public GameObject StartPannel ;
    public Transform player;

    public float spawnDistance = 2 ;

    public float hauteur = 2 ;

    // Start is called before the first frame update
    void Start()
    {
        
        StartPannel.transform.LookAt(new Vector3(2 * StartPannel.transform.position.x - player.position.x, StartPannel.transform.position.y, 2 * StartPannel.transform.position.z - player.position.z)); 
        // StartPannel.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
        StartPannel.transform.position = player.position + player.forward * spawnDistance + new Vector3(0, hauteur, 0);
        StartPannel.transform.Rotate(Vector3.up, -30.0f);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
