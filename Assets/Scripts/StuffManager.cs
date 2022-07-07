using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class StuffManager : MonoBehaviour
{
    public float _money = 0;
    public int _carsWereParked = 0;
    [SerializeField] Text carScore;
    [SerializeField] Text clock;

    private int LevelComplete = 0;

    public enum LevelNumber
    {
        Level_1 = 1,
        Level_2,
        Level_3,
        Level_4,
        Level_5,
        Level_6,
        Level_7,
        Level_8,
        Level_9,
        Level_10,
        Level_11,
        Level_12
    }

    public LevelNumber levelNumber;

    DateTime date1 = new DateTime();

    private void Start()
    {
        CarsMoveParking.wasParked += AddCarScore;
        date1 = date1.AddHours(9);
        clock.text = date1.ToString("HH:mm");
    }

    private void Update()
    {
        if (date1.Hour == 18)
        {
            LevelComplete = (int)levelNumber;
            Debug.Log(LevelComplete);
            PlayerPrefs.SetInt("LevelComplete", LevelComplete);
            SceneManager.LoadScene($"Level_{LevelComplete + 1}");
        }
    }

    private void FixedUpdate()
    {
        date1 = date1.AddSeconds(1);
        clock.text = date1.ToString("HH:mm");
        
    }

    void AddCarScore()
    {
        _carsWereParked++;
        carScore.text = _carsWereParked.ToString();
        if (_carsWereParked == 4)
        {
            
        }

    }
}
    

    
  

    
