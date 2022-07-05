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

    private List<int> carToChangeLevel = new List<int>()
    {
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
    };
    private void Start()
    {
        CarsMoveParking.wasParked += AddCarScore;
    }

    

    void AddCarScore()
    {
        _carsWereParked++;

        for (int i = 1; i < carToChangeLevel.Count; i++)
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

        }
        /*switch (ff)
        {
            case 1:
                if (_carsWereParked == 1)
                {
                    LevelComplete = 1;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene("Level_2");
                }
                break;
            case 2:
                if (_carsWereParked == 2)
                {
                    LevelComplete = 2;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene("Level_3");
                }
                break;
            case 3:
                if (_carsWereParked == 2)
                {
                    LevelComplete = 2;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene("Level_4");
                }
                break;
            case 4:
                if (_carsWereParked == 2)
                {
                    LevelComplete = 2;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene("Level_5");
                }
                break;
            case 5:
                if (_carsWereParked == 2)
                {
                    LevelComplete = 2;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene("Level_6");
                }
                break;
            case 6:
                if (_carsWereParked == 2)
                {
                    LevelComplete = 2;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene("Level_7");
                }
                break;
            case 7:
                if (_carsWereParked == 2)
                {
                    LevelComplete = 2;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene("Level_8");
                }
                break;
            case 8:
                if (_carsWereParked == 2)
                {
                    LevelComplete = 2;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene("Level_9");
                }
                break;
            case 9:
                if (_carsWereParked == 2)
                {
                    LevelComplete = 2;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene("Level_10");
                }
                break;
            case 10:
                if (_carsWereParked == 2)
                {
                    LevelComplete = 2;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene("Level_11");
                }
                break;
            case 11:
                if (_carsWereParked == 2)
                {
                    LevelComplete = 2;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene("Level_12");
                }
                break;
            case 12:
                if (_carsWereParked == 2)
                {
                    LevelComplete = 2;
                    PlayerPrefs.SetInt("LevelComplete", LevelComplete);
                    SceneManager.LoadScene("Menu");
                }
                break;
            default:
                Debug.Log("ggg");
                break;
        }*/


    }
}
    

    
  

    
