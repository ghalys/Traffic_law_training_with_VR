using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    // public int soundLevel = 0; // Niveau de son actuel
    public List<Button> buttons = new List<Button>();
    public Button mute ;
    public Button button1; // Référence au bouton 1
    public Button button2; // Référence au bouton 2
    public Button button3; // Référence au bouton 2
    public Button button4; // Référence au bouton 2


    private Color activeColor = Color.blue; // Couleur du bouton actif
    private Color inactiveColor = Color.white; // Couleur du bouton inactif

    void Start()
    {
        buttons.Add(button1);
        buttons.Add(button2);
        buttons.Add(button3);
        buttons.Add(button4);
        SetSoundLevelMenu(GameManager.soundLevel);
    }
    public void SetSoundLevelMenu(int sound){
            for (int k=0;k<buttons.Count;k++){
                if(k<=sound-1){
                    buttons[k].image.color = activeColor;
                }
                else{
                    buttons[k].image.color = inactiveColor;
                }
            }
            SetSoundLevel(sound);
            GameManager.Change_sound(sound);
    }
    void SetSoundLevel(int level)
    {
         AudioListener.volume = level;
    }
}
