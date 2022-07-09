using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
using Random = UnityEngine.Random;

public class StuffManager : MonoBehaviour
{
    [SerializeField] int _money = 50;
    [SerializeField] int _carsWereParked = 0;
    [SerializeField] Text carScore;
    [SerializeField] Text moneyScore;
    [SerializeField] Text clock;
    [SerializeField] GameObject DialogBubble;
    [SerializeField] GameObject blackoutCanvas;
    [SerializeField] Animator Animator;

    public Action clearParking;


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
        date1 = date1.AddHours(9);
        clock.text = date1.ToString("HH:mm");
        moneyScore.text = _money.ToString() + "$";
        blackoutCanvas.SetActive(true);
        /*StartCoroutine(c_Alpha(0.0f, 2.0f));*/
        Animator.SetBool("BlockoutOFF", true);
        Invoke("HideTransition", 1.5f);
    }

    private void OnEnable()
    {
        CarsMoveParking.wasParked += UpdateScore;
    }

    private void OnDisable()
    {
        CarsMoveParking.wasParked -= UpdateScore;
    }

    void HideTransition()
    {

        Animator.SetBool("BlockoutOFF", false);
        blackoutCanvas.SetActive(false);
    }

    private void Update()
    {
        if (date1.Hour == 18)
        {
            ChangeLevel();
        }
    }

    private void ChangeLevel()
    {
        LevelComplete = (int)levelNumber;
        PlayerPrefs.SetInt("LevelComplete", LevelComplete);
        SceneManager.LoadScene($"Level_{LevelComplete + 1}");
    }

    private void FixedUpdate()
    {
        date1 = date1.AddSeconds(1);
        clock.text = date1.ToString("HH:mm");
        
    }
    void cleanParking()
    {
        
        var hour = Random.Range(1, 3);
        date1 = date1.AddHours(hour);
        Animator.SetBool("BlockoutON", false);
        DialogBubble.SetActive(false);
        Animator.SetBool("BlockoutOFF", true);
        Invoke("HideTransition", 1.5f);
    }
    void CleanParkingStart()
    {
        Animator.SetBool("BlockoutON", true);
        clearParking?.Invoke();
        Invoke("cleanParking", 2f);
    }

    void UpdateScore()
    {
        _carsWereParked++;
        carScore.text = _carsWereParked.ToString();
        _money = _money + 100;
        moneyScore.text = _money.ToString() + "$";

        if (_carsWereParked == 6)
        {
            DialogBubble.SetActive(true);
            blackoutCanvas.SetActive(true);
            Invoke("CleanParkingStart", 3f);
        }
    }

    

}