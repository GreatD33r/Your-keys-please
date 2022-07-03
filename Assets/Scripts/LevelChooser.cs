using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChooser : MonoBehaviour
{
    [SerializeField] private Button ButtonLoad2;
    [SerializeField] private Button ButtonLoad3;
    [SerializeField] private Button ButtonLoad4;
    [SerializeField] private Button ButtonLoad5;
    [SerializeField] private Button ButtonLoad6;
    [SerializeField] private Button ButtonLoad7;
    [SerializeField] private Button ButtonLoad8;
    [SerializeField] private Button ButtonLoad9;
    [SerializeField] private Button ButtonLoad10;
    [SerializeField] private Button ButtonLoad11;
    [SerializeField] private Button ButtonLoad12;

    private int _carswereParked;

    private void Start()
    {
        ButtonLoad2.interactable = false;
        ButtonLoad3.interactable = false;
        ButtonLoad4.interactable = false;
        ButtonLoad5.interactable = false;
        ButtonLoad6.interactable = false;
        ButtonLoad7.interactable = false;
        ButtonLoad8.interactable = false;
        ButtonLoad9.interactable = false;
        ButtonLoad10.interactable = false;
        ButtonLoad11.interactable = false;
        ButtonLoad12.interactable = false;
        _carswereParked = PlayerPrefs.GetInt("CarWereParked");
        if (_carswereParked == 1)
        {
            ButtonLoad2.interactable = true;
        }
    }
    public void LoadLevel(int Level)
    {
        SceneManager.LoadScene(Level);
    }



}
