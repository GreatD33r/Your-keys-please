using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSit : MonoBehaviour
{
    public static Transform enteredObject;
    public static bool _playerNear = false;
    public static GameObject _entObj;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
           
            enteredObject = collision.transform;
            _entObj = collision.gameObject;
        }

        else if (collision.CompareTag("Player"))
        {
            _playerNear = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerNear = false;
        }
    }
}
