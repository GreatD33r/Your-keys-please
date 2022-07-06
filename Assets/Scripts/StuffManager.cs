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

    private List<int> timeToChangeLevel = new List<int>()
    {
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
    };

    DateTime date1 = new DateTime();

    private void Start()
    {
        CarsMoveParking.wasParked += AddCarScore;
        date1 = date1.AddHours(9);
        clock.text = date1.ToString("HH:mm");
    }
    
    private void FixedUpdate()
    {
        date1 = date1.AddSeconds(1);
        clock.text = date1.ToString("HH:mm");
        for (int i = 1; i < timeToChangeLevel.Count; i++)
        {
            
                if (date1.Hour == 18)
                {
                    LevelComplete = i;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene($"Level_{i + 1}");
                }
            
        }
    }

    void AddCarScore()
    {
        _carsWereParked++;
        carScore.text = _carsWereParked.ToString();
        Debug.Log(date1.Hour);
        

        /*for (int i = 1; i < carToChangeLevel.Count; i++)
        {
            if ((int)levelNumber == i)
            {
                carScore.text = _carsWereParked.ToString();
                if (_carsWereParked == carToChangeLevel[i - 1])
                {
                    LevelComplete = i;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene($"Level_{i + 1}");
                }
            }

        }*/
    }
}
    

    
  

    
