using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araba : MonoBehaviour
{
    public WheelCollider �nsoltekerlek, �nsagtekerlek, arkasoltekerlek, arkasa�tekerlek;

    public float motorh�z�, d�nmeh�z�;
    public Joystick tus;

    void Update()
    {
        arkasa�tekerlek.motorTorque = motorh�z� * tus.Vertical;
        arkasoltekerlek.motorTorque = motorh�z� * tus.Vertical;
        �nsagtekerlek.steerAngle = d�nmeh�z� * tus.Horizontal;
        �nsoltekerlek.steerAngle = d�nmeh�z� * tus.Horizontal;
    }
}