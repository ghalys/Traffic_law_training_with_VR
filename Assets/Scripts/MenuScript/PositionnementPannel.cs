using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionnementPannel : MonoBehaviour
{
    public float spawnDistance = 9 ;
    public float hauteur = 0.3f ; 
    public Transform player;

    
   void Start()
    {
        
      transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
      transform.LookAt(new Vector3(2 * transform.position.x - player.position.x, transform.position.y, 2 * transform.position.z - player.position.z));                   
            
        }
}
