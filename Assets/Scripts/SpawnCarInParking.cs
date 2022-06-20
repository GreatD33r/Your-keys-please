using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SpawnCarInParking : MonoBehaviour
{
    public GameObject[] carType;
    private int CarNumber;

    public CinemachineVirtualCamera _vCam;
    private Transform _currentCar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _currentCar = collision.transform;
        _vCam.Follow = _currentCar;
    }

    private void Start()
    {
        CarNumber = SceneChangeToParking.CarNumber;
        Instantiate(carType[CarNumber], transform.position, Quaternion.identity);
    }
}
