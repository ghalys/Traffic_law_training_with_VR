using System;
using UnityEngine;

public class DetectFailure : MonoBehaviour
 
{
    public string tago;
    public bool PriorityRespect = true;
    public bool PriorityCheck = false;
    public FailMenu fail_menu;
    public String msg = "";


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="VehicleRobot"){
            fail_menu.gameObject.SetActive(true);
            fail_menu.SetMessageCollisionRobot();
        }
    }
        public void Priority()
    {
        this.PriorityRespect = false;
    }
    public void PriorityFinalCheck()
    {
        if (this.PriorityRespect==true) { 
            this.PriorityCheck = true;
        } else
        {
            fail_menu.gameObject.SetActive(true);
            fail_menu.SetMessagePriorite_ADroite();

        }

    }
}
