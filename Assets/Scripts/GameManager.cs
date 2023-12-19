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
    public static bool conduite_joystick = false;
    public static int soundLevel = 2; // Niveau de son actuel

    static GameManager (){
    
    maListe.Add("PrioritéV2");
    maListe.Add("Rond Point");
    maListe.Add("SceneBonde");
    }
    public static void Change_sound(int sound){
        soundLevel = sound;
    }
    public static void Change_conduite(){
        conduite_joystick = !conduite_joystick;
    }
    public static void scene_suivante(){
        if (index_situation<max_sit){
            SceneManager.LoadScene(maListe[index_situation]);
            index_situation++;
        }
        else{
            SceneManager.LoadScene("Debut");
            modeLibre = false;

        }
    }

}
