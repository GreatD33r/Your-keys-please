using UnityEngine;
using System;
using Cinemachine;

public class SceneChangeToParking : MonoBehaviour
{
    public int CarNumber;

    [SerializeField] private Vector2[] parkPoints;
    [SerializeField] private Vector2[] levelPoints;
    [SerializeField] private GameObject CameraBorder;
    [SerializeField] private CameraMng CameraMng;
    [SerializeField] private GameObject Player;
    [SerializeField] private CinemachineVirtualCamera _vCam;
    [SerializeField] private GameObject StopLine;

    public Action goToPark;


    private void Start()
    {
        CarsMoveParking.wasParked += ChangeToLevel;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            CarNumber = (int)collision.GetComponent<CarsMove>().carNumber;
            goToPark?.Invoke();
            ChangeToPark();
            Debug.Log(CarNumber);
            Destroy(collision.gameObject);
        }
    }

    void ChangeToPark()
    {
       
        var parkingCameraBorder = CameraBorder.GetComponent<PolygonCollider2D>();
        parkingCameraBorder.points = parkPoints;
        var parkingTransformBorder = CameraBorder.GetComponent<Transform>();
        parkingTransformBorder.position = new Vector2(75, 2);
        var Cardrive = CameraMng.GetComponent<CameraMng>();
        Cardrive.CanDrive = false;
    }

    public void ChangeToLevel()
    {
        var parkingCameraBorder = CameraBorder.GetComponent<PolygonCollider2D>();
        parkingCameraBorder.points = levelPoints;
        var parkingTransformBorder = CameraBorder.GetComponent<Transform>();
        parkingTransformBorder.position = new Vector3(-1, 0);
        var Cardrive = CameraMng.GetComponent<CameraMng>();
        Cardrive.CanDrive = true;
        Player.SetActive(true);
        var playertransform = Player.GetComponent<Transform>();
        _vCam.Follow = playertransform;
        StopLine.SetActive(true);
    }


}
