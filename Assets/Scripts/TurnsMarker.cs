using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TurnsMarker : MonoBehaviour
{
    public static Action turn;
    public static Action<bool> Busy;
    public static bool isBusy;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("veerCar"))
        {
            isBusy = true;
            turn?.Invoke();
            Busy?.Invoke(isBusy);
        }
        else
        {
            isBusy = false;
        }
    }
}
