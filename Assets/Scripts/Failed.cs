using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Failed : MonoBehaviour
{

    public GameObject FailedM ; 

    public Transform player;

    public float spawnDistance = 2 ;

    public float hauteur = 2 ;

    public bool ispaused=true ;
    public List<GameObject> listeDeGameObjects;

    
    public GameObject body ;

    public GameObject components ;
    public GameObject Board ;

    public GameObject wheel1 ;
    public GameObject wheel2 ;

    public GameObject wheel3 ;

    public GameObject wheel4 ;
    
    // Start is called before the first frame update
    void Start()
    {
      FailedM.SetActive(true) ;  
      ispaused = true;
      Time.timeScale = 0;
      FailedM.transform.position=player.position + new Vector3(player.forward.x,hauteur,player.forward.z).normalized*spawnDistance ;
      FailedM.transform.LookAt(new Vector3(2 * FailedM.transform.position.x - player.position.x, FailedM.transform.position.y, 2 * FailedM.transform.position.z - player.position.z));
      wheel1.SetActive(false) ;
      wheel2.SetActive(false) ;
      wheel3.SetActive(false) ;
      wheel4.SetActive(false) ;
      body.SetActive(false) ;
      components.SetActive(false) ;
      Board.SetActive(false) ;      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitterF(){
        SceneManager.LoadScene("debut"); 

    }
    public void Recommencer(){
        
    }
}
