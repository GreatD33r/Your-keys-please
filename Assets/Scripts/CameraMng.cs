using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraMng : MonoBehaviour
{

    private CinemachineVirtualCamera _vCam;
    public static Transform _currentCar;
    [SerializeField] GameObject _player;
    private bool _plNear;
    public static bool _plSit = false;
    [SerializeField] GameObject _stopLine;
    bool _busy;
    public static bool _plHadKey;
    bool barrierActive;

    private void Start()
    {
        _vCam = GetComponent<CinemachineVirtualCamera>();
        
    }
    private void Update()
    {
        barrierActive = CheckpointSorter.barrierActive;
        _plHadKey = Hero._playerHadKey;
        _plNear = PlayerSit._playerNear;
        _busy = RoadBusy._isBusy;
        //_currentCar = PlayerSit.enteredObject;
        

        if (Input.GetKeyDown(KeyCode.E) & _plNear & _busy & _plHadKey & barrierActive)
        {
            
            _player.SetActive(false);
            _vCam.Follow = _currentCar;
            _plSit = true;
        }
        if (_plSit & Input.GetKeyDown(KeyCode.W) )
        {
            _currentCar.gameObject.GetComponent<CarsMove>().verticalSpeed = 4;
            _stopLine.SetActive(false);
            
        }
        
    }
}
