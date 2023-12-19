using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePassagePieton : MonoBehaviour
{
    private int nbr_pietons = 0;
        public FailMenu fail_menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Check_passage(){
        if (nbr_pietons != 0){
            fail_menu.gameObject.SetActive(true);
            fail_menu.SetMessagepassage_pieton();
        }
    }
    public void add_pieton(){
        nbr_pietons+=1;
    }
    public void remove_pieton(){
        nbr_pietons-=1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
