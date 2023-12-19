using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto : MonoBehaviour
{
    public GameObject TutoPannel ;
    public GameObject carcomponent;
    public bool show_tuto ;
    public bool aide_ignorer_tuto;

    public   GameObject debut ;

    void Start()
    {
        show_tuto = GameManager.showTuto;
        if(show_tuto||aide_ignorer_tuto){
        Time.timeScale = 0;
        carcomponent.SetActive(false);
        }
        else{
            TutoPannel.SetActive(false) ;        
            debut.SetActive(true);
        }

    }
    public void dontShow() {
        GameManager.showTuto = false;
    }

    public void passer(GameObject ProchainPanel) {
        TutoPannel.SetActive(false) ;
        ProchainPanel.SetActive(true) ;
    }
}
