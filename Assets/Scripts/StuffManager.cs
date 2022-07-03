using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class StuffManager : MonoBehaviour
{
    public float _money = 0;
    public int _carsWereParked = 0;
    [SerializeField] Text carScore;

    private void Start()
    {
        CarsMoveParking.wasParked += AddCarScore;
    }


    void AddCarScore()
    {
        _carsWereParked++;
        carScore.text = _carsWereParked.ToString() + "/5";
        if (_carsWereParked == 1)
        {
            PlayerPrefs.SetInt("CarWereParked", _carsWereParked);
        }
    }
}
    

    
  

    
