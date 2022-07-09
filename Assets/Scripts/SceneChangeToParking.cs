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
    private PolygonCollider2D parkingCameraBorder;
    private Transform parkingTransformBorder;
    private CameraMng Cardrive;
    private Transform playertransform;


    public Action goToPark;

    private void OnEnable()
    {
        CarsMoveParking.wasParked += ChangeToLevel;
    }

    private void OnDisable()
    {
        CarsMoveParking.wasParked -= ChangeToLevel;
    }
    


    private void Start()
    {
        
        parkingCameraBorder = CameraBorder.GetComponent<PolygonCollider2D>();
        parkingTransformBorder = CameraBorder.GetComponent<Transform>();
        Cardrive = CameraMng.GetComponent<CameraMng>();
        playertransform = Player.GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            
            CarNumber = (int)collision.GetComponent<CarsMove>().carNumber;
            goToPark?.Invoke();
            ChangeToPark();
            Destroy(collision.gameObject);
        }
    }

    void ChangeToPark()
    {
        parkingCameraBorder.points = parkPoints;
        parkingTransformBorder.position = new Vector2(75, 2);
        Cardrive.CanDrive = false;

    }

    [SerializeField] CheckpointSorter CheckpointSorter;
    [SerializeField] PlayerSit PlayerSit;

    public void ChangeToLevel()
    {
        
        parkingTransformBorder.position = new Vector3(-1, 0);
        parkingCameraBorder.points = levelPoints;
        Cardrive.CanDrive = true;
        Player.SetActive(true);
        _vCam.Follow = playertransform;
        StopLine.SetActive(true);

        PlayerSit._playerNear = false;
        Hero._playerHadKey = false;
        CheckpointSorter.barrierActive = false;
        CameraMng._plSit = false;
    }


}
