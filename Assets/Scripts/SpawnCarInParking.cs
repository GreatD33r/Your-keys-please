using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SpawnCarInParking : MonoBehaviour
{
    public GameObject[] carType;
    [SerializeField] SceneChangeToParking sceneChangeToParking;

    public CinemachineVirtualCamera _vCam;
    private Transform _currentCar;

    private void Start()
    {
        sceneChangeToParking.goToPark += SpawnCar;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _currentCar = collision.transform;
        _vCam.Follow = _currentCar;

    }

    private void SpawnCar()
    {
        var CarNumber = sceneChangeToParking.GetComponent<SceneChangeToParking>().CarNumber;
        Instantiate(carType[CarNumber], transform.position, Quaternion.identity);
    }
}
