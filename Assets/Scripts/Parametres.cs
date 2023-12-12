using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Parametres : MonoBehaviour
{
    public GameObject Parametre;    
    public GameObject PauseObjet ; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void GoToMenu()
    {
        Parametre.SetActive(false) ;
        PauseObjet.SetActive(true) ;
        
    }
}
        
