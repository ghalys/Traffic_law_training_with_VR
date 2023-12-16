using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bravo : MonoBehaviour
{

    public GameObject Bravoo ; 
    public GameObject Situations ;
    
    // Start is called before the first frame update
    void Start()
    {
      Bravoo.SetActive(true) ;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Quitter(){
        Bravoo.SetActive(false) ;

    }
    public void ChoisirAutreSituation(){
        SceneManager.LoadScene("debut");

    }
}
