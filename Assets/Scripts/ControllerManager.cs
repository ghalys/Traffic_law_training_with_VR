using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.VisualScripting;

public class ControllerManager : MonoBehaviour
{
    public InputActionReference accel;
    public InputActionReference decel;
    private float value=0;

    // Start is called before the first frame update
    void Start()
    {   
            accel.action.performed += ctx => TriggerLeftPerformed(ctx);
            accel.action.canceled += ctx => TriggerLeftCanceled(ctx);
            decel.action.performed += ctx => TriggerRightPerformed(ctx);
            decel.action.canceled += ctx => TriggerRightPerformed(ctx);
    }


    void TriggerLeftPerformed(InputAction.CallbackContext context)
    {
        // Get the value of the trigger press
        value = context.ReadValue<float>();

        // Your interaction logic here
        // You can use the 'triggerValue' for any specific actions based on how much the trigger is pressed
    }
    void TriggerRightPerformed(InputAction.CallbackContext context)
    {
        // Get the value of the trigger press
        value = -context.ReadValue<float>();

    }
    void TriggerLeftCanceled(InputAction.CallbackContext context)
    {
        // Reset the value when the accel action is canceled
        value = 0;
    }
    void TriggerRightCanceled(InputAction.CallbackContext context)
    {
        // Reset the value when the accel action is canceled
        value = 0;
    }
    public float get_value()
    {
        return value;
    }
}
