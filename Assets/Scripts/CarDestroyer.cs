using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CarDestroyer : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            Destroy(collision.gameObject);
        }
    }
}
