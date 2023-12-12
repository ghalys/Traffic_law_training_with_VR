using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public float soundLevel = 0.0f; // Niveau de son actuel
    public Button mute ;
    public Button button1; // Référence au bouton 1
    public Button button2; // Référence au bouton 2
    public Button button3; // Référence au bouton 2
    public Button button4; // Référence au bouton 2


    private Color activeColor = Color.blue; // Couleur du bouton actif
    private Color inactiveColor = Color.white; // Couleur du bouton inactif

    void Start()
    {
        // Assurez-vous que le son est configuré au démarrage
        SetSoundLevel(soundLevel);
    }
    public void SetSoundLevel0()
    {
        soundLevel = 0.0f;
        SetSoundLevel(soundLevel);

        // Changez la couleur des boutons en conséquence
        button1.image.color = inactiveColor;
        button2.image.color = inactiveColor; 
        button3.image.color = inactiveColor;
        button4.image.color = inactiveColor;
    }

    public void SetSoundLevel1()
    {
        soundLevel = 1.0f;
        SetSoundLevel(soundLevel);

        // Changez la couleur des boutons en conséquence
        button1.image.color = activeColor;
        button2.image.color = inactiveColor;
        button3.image.color = inactiveColor;
        button4.image.color = inactiveColor;
    }

    public void SetSoundLevel2()
    {
        soundLevel = 2.0f;
        SetSoundLevel(soundLevel);

        // Changez la couleur des boutons en conséquence
        button1.image.color = activeColor;
        button2.image.color = activeColor;
        button3.image.color = inactiveColor;
        button4.image.color = inactiveColor;
    }

    public void SetSoundLevel3()
    {
        soundLevel = 3.0f;
        SetSoundLevel(soundLevel);

        // Changez la couleur des boutons en conséquence
        button1.image.color = activeColor;
        button2.image.color = activeColor;
        button3.image.color = activeColor;
        button4.image.color = inactiveColor;
    
    }

    public void SetSoundLevel4()
    {
        soundLevel = 4.0f;
        SetSoundLevel(soundLevel);

        // Changez la couleur des boutons en conséquence
        button1.image.color = activeColor;
        button2.image.color = activeColor;
        button3.image.color = activeColor;
        button4.image.color = activeColor;

        
        
    }


    // Implémentez SetSoundLevel pour ajuster le son en fonction du niveau
    void SetSoundLevel(float level)
    {
         AudioListener.volume = level;
    }
}
