using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public static class GameManager
{
    public static bool showTuto = true;
    public static List<string> maListe = new List<string>();
    public static bool modeLibre = false;
    public static int index_situation = 0;
    public static int max_sit = 3;
    static GameManager (){
    
    maListe.Add("PrioritéV2");
    maListe.Add("Rond Point");
    maListe.Add("Rond Point");
    // maListe.Add("Element 3");
    }
    public static void scene_suivante(){
        if (index_situation<max_sit){
            Debug.Log(index_situation);
            SceneManager.LoadScene(maListe[index_situation]);
            index_situation++;
        }
        else{
            SceneManager.LoadScene("Debut");

        }
    }

}
