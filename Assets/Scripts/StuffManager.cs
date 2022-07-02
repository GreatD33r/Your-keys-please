using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StuffManager : MonoBehaviour
{
    public float _money = 0;
    public int _carsWereParked = 0;
    [SerializeField] CarsMoveParking fff;
    

    
    public void sss(CarsMoveParking fff)
    {
        fff._wasParked += AddCar;
    }

    public void AddCar()
    {
        _carsWereParked = _carsWereParked++;
        Debug.Log("ffff");
        SceneManager.LoadScene("Level_1");
    }
}
