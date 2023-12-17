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

    

    public GameObject Carcomponents ;
    
    // Start is called before the first frame update
    void Start()
    {
      FailedM.SetActive(true) ;  
      ispaused = true;
      Time.timeScale = 0;
      FailedM.transform.LookAt(player.transform.position);
      FailedM.transform.position = player.position + player.forward * spawnDistance + new Vector3(0, hauteur,0);
      FailedM.transform.Rotate(0, 180, 0);
      Carcomponents.SetActive(false) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitterF(){
        SceneManager.LoadScene("debut"); 

    }
    public void Recommencer(){
             SceneManager.LoadScene("PrioritéV2"); 
   
    }
}
