
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ParametresMenu : MonoBehaviour
{
    public GameObject MenuParametre; 
    public GameObject Menu ;   


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
        MenuParametre.SetActive(false) ;
        Menu.SetActive(true) ;
    }
}
        