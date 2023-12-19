using System;
using UnityEngine;

public class DetectFailure : MonoBehaviour
 
{
    public string tago;
    public bool PriorityRespect = true;
    public bool PriorityCheck = false;
    public FailMenu fail_menu;


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="VehicleRobot"){
            fail_menu.gameObject.SetActive(true);
            if (!PriorityRespect){
            fail_menu.SetMessageCollisionRobotEtPriorite();
            }
            else{
            fail_menu.SetMessageCollisionRobot();
            }
            collision.gameObject.SetActive(false);
        }
        else if ( collision.gameObject.tag !="End"){ //tout autre objet sauf la ligne d'arrivée
            fail_menu.gameObject.SetActive(true);
            fail_menu.SetMessageCollision(collision.gameObject.name);
            collision.gameObject.SetActive(false);
        }
    }
        
        public void Priority()
    {
        this.PriorityRespect = false;
    }

    public void Exited(){
            fail_menu.gameObject.SetActive(true);
            fail_menu.SetMessageExitedRoad();
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
