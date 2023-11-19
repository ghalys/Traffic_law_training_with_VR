using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarUi : MonoBehaviour
{
    public Transform target;

    public float smooth = 0.3f;
    public float distance = 5.0f;
    public float height = 1.0f;
    public float Angle = 20;
    public Camera myxrcamera;

    
    private int gearst = 0;
    private float thisAngle = -150;

    private VehicleControl carScript;
        [System.Serializable]
    public class CarUIClass
    {

        // public Image tachometer;

        public TMP_Text speedText;
        public TMP_Text GearText;

    }
    public CarUIClass CarUI;

    public void ShowCarUI()
    {



        gearst = carScript.currentGear;
        CarUI.speedText.text = ((int)carScript.speed).ToString();




        if (carScript.carSetting.automaticGear)
        {

            if (gearst > 0 && carScript.speed > 1)
            {
                CarUI.GearText.color = Color.green;
                CarUI.GearText.text = gearst.ToString();
            }
            else if (carScript.speed > 1)
            {
                CarUI.GearText.color = Color.red;
                CarUI.GearText.text = "R";
            }
            else
            {
                CarUI.GearText.color = Color.white;
                CarUI.GearText.text = "N";
            }

        }
        else
        {

            if (carScript.NeutralGear)
            {
                CarUI.GearText.color = Color.white;
                CarUI.GearText.text = "N";
            }
            else
            {
                if (carScript.currentGear != 0)
                {
                    CarUI.GearText.color = Color.green;
                    CarUI.GearText.text = gearst.ToString();
                }
                else
                {

                    CarUI.GearText.color = Color.red;
                    CarUI.GearText.text = "R";
                }
            }

        }
        
        thisAngle = (carScript.motorRPM / 20) - 175;
        thisAngle = Mathf.Clamp(thisAngle, -180, 90);

        // CarUI.tachometerNeedle.rectTransform.rotation = Quaternion.Euler(0, 0, -thisAngle);

    }

    // Start is called before the first frame update
    void Start()
    {
        carScript = (VehicleControl)target.GetComponent<VehicleControl>();

    }


    // Update is called once per frame
    void Update()
    {
        ShowCarUI();

        myxrcamera.fieldOfView = Mathf.Clamp(carScript.speed / 10.0f + 60.0f, 60, 90.0f);


        
    }

}