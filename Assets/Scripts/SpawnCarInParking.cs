using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SpawnCarInParking : MonoBehaviour
{
    public GameObject[] carType;
    private int CarNumber;
    [SerializeField] StuffManager StuffManager;

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
        
        var ddd = Instantiate(carType[CarNumber], transform.position, Quaternion.identity);
        StuffManager.sss(ddd.GetComponent<CarsMoveParking>());
    }
}
