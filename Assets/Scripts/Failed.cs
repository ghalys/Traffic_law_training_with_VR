using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Failed : MonoBehaviour
{

    public GameObject FailedM ; 
    
    // Start is called before the first frame update
    void Start()
    {
      FailedM.SetActive(true) ;  
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
