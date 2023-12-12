using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sure : MonoBehaviour
{
    public GameObject Pause ;
    public GameObject Suree ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Oui ()
    {
        SceneManager.LoadScene("debut");
    }

    public void Non() 
    {
        Suree.SetActive(false) ;
        Pause.SetActive(true) ;
    }
}
