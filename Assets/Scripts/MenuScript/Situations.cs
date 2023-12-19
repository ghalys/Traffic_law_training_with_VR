using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Situations : MonoBehaviour
{
    public GameObject situations ; 
    public GameObject Menu;
 
    public void GoMenu(){
        situations.SetActive(false) ;
        Menu.SetActive(true);

    }

    public void Situation1(){
        SceneManager.LoadScene("Rond Point");

    }
    public void Situation2(){
        SceneManager.LoadScene("PrioritéV2");

    }
    public void Situation3(){
        SceneManager.LoadScene("SceneBonde");
        
    }
}
