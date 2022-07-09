using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingPlaceMng : MonoBehaviour
{

    private GameObject currentCar;
    [SerializeField] StuffManager stfMng;
    private int Chance;

    private void OnEnable()
    {
        stfMng.clearParking += DeleteCar;
    }
    private void OnDisable()
    {
        stfMng.clearParking -= DeleteCar;
    }

    void DeleteCar()
    {
        Chance = Random.Range(0, 101);
        Debug.Log(Chance);
        if (Chance >= 50)
        {
            Destroy(currentCar);
            Debug.Log("CarDelete");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            currentCar = collision.gameObject;
        }
    }

}
