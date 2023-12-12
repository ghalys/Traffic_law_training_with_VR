using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clignotant : MonoBehaviour
{
    // public GameObject feuxAvantGauche;
    // public GameObject feuxAvantDroit;
    // public GameObject feuxArriereGauche;
    // public GameObject feuxArriereDroit;

    public float dureeClignotement = 5f; // Durée d'un cycle de clignotement en secondes
    private bool clignotantActif = false;
    private float tempsProchainClignotement;

    void Start()
    {
        // Initialiser le temps du prochain clignotement
        tempsProchainClignotement = Time.time + dureeClignotement;
    }

    void Update()
    {

        // Vérifier si le temps du prochain clignotement est atteint
        if (Time.time >= tempsProchainClignotement)
        {
            // Inverser l'état du clignotant
            clignotantActif = !clignotantActif;
            gameObject.SetActive(clignotantActif);

            

            // Mettre à jour le temps du prochain clignotement
            tempsProchainClignotement = Time.time + dureeClignotement;
        }
    }
}

