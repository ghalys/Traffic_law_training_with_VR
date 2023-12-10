using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Recommencer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void recommencerscene() {
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Rechargez la scène actuelle
        SceneManager.LoadScene(currentSceneName);
    }
}
