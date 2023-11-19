using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
public class VehicleCamera : MonoBehaviour
{



    public Transform target;

    public float smooth = 0.3f;
    public float distance = 5.0f;
    public float height = 1.0f;
    public float Angle = 20;


    public List<Transform> cameraSwitchView;
    public LayerMask lineOfSightMask = 0;



    public Camera myxrcamera;

    // private float yVelocity = 0.0f;
    // private float xVelocity = 0.0f;
    [HideInInspector]
    public int Switch;

    private int gearst = 0;
    private float thisAngle = -150;
    private float restTime = 0.0f;


    private Rigidbody myRigidbody;



    private VehicleControl carScript;



  


    


    ////////////////////////////////////////////// TouchMode (Control) ////////////////////////////////////////////////////////////////////





    public void CameraSwitch()
    {
        Switch++;
        if (Switch > cameraSwitchView.Count) { Switch = 0; }
    }


    public void CarAccelForward(float amount)
    {
        carScript.accelFwd = amount;
    }

    public void CarAccelBack(float amount)
    {
        carScript.accelBack = amount;
    }

    public void CarSteer(float amount)
    {
        carScript.steerAmount = amount;
    }

    public void CarHandBrake(bool HBrakeing)
    {
        carScript.brake = HBrakeing;
    }

    public void CarShift(bool Shifting)
    {
        carScript.shift = Shifting;
    }



    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    

    public void RestCar()
    {

        if (restTime == 0)
        {
            myRigidbody.AddForce(Vector3.up * 500000);
            myRigidbody.MoveRotation(Quaternion.Euler(0, transform.eulerAngles.y, 0));
            restTime = 2.0f;
        }

    }




    public void ShowCarUI()
    {



        gearst = carScript.currentGear;




        




        thisAngle = (carScript.motorRPM / 20) - 175;
        thisAngle = Mathf.Clamp(thisAngle, -180, 90);

    }



    void Start()
    {

        carScript = (VehicleControl)target.GetComponent<VehicleControl>();

        myRigidbody = target.GetComponent<Rigidbody>();

        cameraSwitchView = carScript.carSetting.cameraSwitchView;
        Switch = 1;

    }




    void Update()
    {

        if (!target) return;


        carScript = (VehicleControl)target.GetComponent<VehicleControl>();



        if (Input.GetKeyDown(KeyCode.G))
        {
            RestCar();
        }





        if (restTime!=0.0f)
        restTime=Mathf.MoveTowards(restTime ,0.0f,Time.deltaTime);




        ShowCarUI();

        myxrcamera.fieldOfView = Mathf.Clamp(carScript.speed / 10.0f + 60.0f, 60, 90.0f);



        if (Input.GetKeyDown(KeyCode.C))
        {
            Switch++;
            if (Switch > cameraSwitchView.Count) { Switch = 0; }
        }



        // if (Switch == 0)
        // {
        //     // Damp angle from current y-angle towards target y-angle

        //     float xAngle = Mathf.SmoothDampAngle(transform.eulerAngles.x,
        //    target.eulerAngles.x + Angle, ref xVelocity, smooth);

        //     float yAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y,
        //     target.eulerAngles.y, ref yVelocity, smooth);

        //     // Look at the target
        //     transform.eulerAngles = new Vector3(xAngle, yAngle,0.0f);

        //     var direction = transform.rotation * -Vector3.forward;
        //     var targetDistance = AdjustLineOfSight(target.position + new Vector3(0, height, 0), direction);


        //     transform.position = target.position + new Vector3(0, height, 0) + direction * targetDistance;


        // }
        // else
        {

            transform.position = cameraSwitchView[Switch - 1].position;
            // transform.rotation = Quaternion.Lerp(transform.rotation, cameraSwitchView[Switch - 1].rotation, Time.deltaTime * 5.0f);

        }

    }



    float AdjustLineOfSight(Vector3 target, Vector3 direction)
    {
        RaycastHit hit;

        if (Physics.Raycast(target, direction, out hit, distance, lineOfSightMask.value))
            return hit.distance;
        else
            return distance;

    }


}
