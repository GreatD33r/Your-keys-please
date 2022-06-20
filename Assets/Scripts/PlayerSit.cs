using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSit : MonoBehaviour
{
    public static Transform enteredObject;
    public static bool _playerNear = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
           
            enteredObject = collision.transform;
            CameraMng._currentCar = enteredObject;
        }

        else if (collision.CompareTag("Player"))
        {
            _playerNear = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            enteredObject = null;
            CameraMng._currentCar = enteredObject;

        }
        if (collision.CompareTag("Player"))
        {
            _playerNear = false;
        }
    }
}
