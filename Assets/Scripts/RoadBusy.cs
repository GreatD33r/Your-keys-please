using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class RoadBusy : MonoBehaviour
{
    public static bool _isBusy = false;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            _isBusy = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            _isBusy = false;
        }
    }

}
