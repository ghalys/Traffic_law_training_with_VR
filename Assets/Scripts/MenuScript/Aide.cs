using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aide : MonoBehaviour
{
    public GameObject tuto;
    public GameObject menu;
    public void afficher_tuto(){
        tuto.SetActive(true);
        menu.SetActive(false);
    }
}
