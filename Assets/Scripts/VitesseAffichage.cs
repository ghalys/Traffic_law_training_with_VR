using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class VitesseAffichage : MonoBehaviour
{
    public VehicleControl target;

    private float maxSpeed; // The maximum speed of the target ** IN KM/H **

    public float minSpeedArrowAngle;
    public float maxSpeedArrowAngle;

    [Header("UI")]
    public RectTransform arrow; // The arrow in the speedometer

    private float speed = 0.0f;
    private void Update()
    {
        speed = target.speed;
        maxSpeed = target.carSetting.LimitForwardSpeed;
        if (arrow != null)
            arrow.localEulerAngles =
                new Vector3(0, 0, Mathf.Lerp(maxSpeedArrowAngle,minSpeedArrowAngle, speed / maxSpeed));
    }
}
