using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Situations : MonoBehaviour
{
    public GameObject Menu ;
    public GameObject Situationss ; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoMenu(){
        Situationss.SetActive(false) ;
        Menu.SetActive(true) ;
    }

    public void Situation1(){
        SceneManager.LoadScene("Rond Point");

    }
    public void Situation2(){
        SceneManager.LoadScene("PrioritéV2");

    }
    public void Situation3(){
        
    }
}
