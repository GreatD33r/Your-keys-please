using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChooser : MonoBehaviour
{
    [SerializeField] private Button ButtonLoad2;
    private int levelIsAvailable2 = 0;
    [SerializeField] private Button ButtonLoad3;
    private int levelIsAvailable3 = 0;
    [SerializeField] private Button ButtonLoad4;
    private int levelIsAvailable4 = 0;
    [SerializeField] private Button ButtonLoad5;
    private int levelIsAvailable5 = 0;
    [SerializeField] private Button ButtonLoad6;
    private int levelIsAvailable6 = 0;
    [SerializeField] private Button ButtonLoad7;
    private int levelIsAvailable7 = 0;
    [SerializeField] private Button ButtonLoad8;
    private int levelIsAvailable8 = 0;
    [SerializeField] private Button ButtonLoad9;
    private int levelIsAvailable9 = 0;
    [SerializeField] private Button ButtonLoad10;
    private int levelIsAvailable10 = 0;
    [SerializeField] private Button ButtonLoad11;
    private int levelIsAvailable11 = 0;
    [SerializeField] private Button ButtonLoad12;
    private int levelIsAvailable12 = 0;

    private int _levelComplete;

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
        _levelComplete = PlayerPrefs.GetInt("LevelComplete");


        /*for (int i = 1; i < 12; i++)
        {
            ButtonLoad2.interactable = true;
            levelIsAvailable2 = 1;
            PlayerPrefs.GetInt("LevelIsAvailable2", levelIsAvailable2);
        }*/

        switch (_levelComplete)
        {
            case 1:
                ButtonLoad2.interactable = true;
                levelIsAvailable2 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable2", levelIsAvailable2);
                break;
            case 2:
                ButtonLoad3.interactable = true;
                levelIsAvailable3 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable3", levelIsAvailable3);
                break;
            case 3:
                ButtonLoad4.interactable = true;
                levelIsAvailable4 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable4", levelIsAvailable4);
                break;
            case 4:
                ButtonLoad5.interactable = true;
                levelIsAvailable5 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable5", levelIsAvailable5);
                break;
            case 5:
                ButtonLoad6.interactable = true;
                levelIsAvailable6 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable6", levelIsAvailable6);
                break;
            case 6:
                ButtonLoad7.interactable = true;
                levelIsAvailable7 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable7", levelIsAvailable7);
                break;
            case 7:
                ButtonLoad8.interactable = true;
                levelIsAvailable8 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable8", levelIsAvailable8);
                break;
            case 8:
                ButtonLoad9.interactable = true;
                levelIsAvailable9 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable9", levelIsAvailable9);
                break;
            case 9:
                ButtonLoad10.interactable = true;
                levelIsAvailable10 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable10", levelIsAvailable10);
                break;
            case 10:
                ButtonLoad11.interactable = true;
                levelIsAvailable11 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable11", levelIsAvailable11);
                break;
            case 11:
                ButtonLoad12.interactable = true;
                levelIsAvailable12 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable12", levelIsAvailable12);
                break;
            default:
                Debug.Log("Не прошел еще");
                break;
        }

        levelIsAvailable2 = PlayerPrefs.GetInt("LevelIsAvailable2");
        if (levelIsAvailable2 == 1)
        {
            ButtonLoad2.interactable = true;
        }

        levelIsAvailable3 = PlayerPrefs.GetInt("LevelIsAvailable3");
        if (levelIsAvailable3 == 1)
        {
            ButtonLoad3.interactable = true;
        }

        levelIsAvailable4 = PlayerPrefs.GetInt("LevelIsAvailable4");
        if (levelIsAvailable4 == 1)
        {
            ButtonLoad4.interactable = true;
        }

        levelIsAvailable5 = PlayerPrefs.GetInt("LevelIsAvailable5");
        if (levelIsAvailable5 == 1)
        {
            ButtonLoad5.interactable = true;
        }

        levelIsAvailable6 = PlayerPrefs.GetInt("LevelIsAvailable6");
        if (levelIsAvailable6 == 1)
        {
            ButtonLoad6.interactable = true;
        }

        levelIsAvailable7 = PlayerPrefs.GetInt("LevelIsAvailable7");
        if (levelIsAvailable7 == 1)
        {
            ButtonLoad7.interactable = true;
        }

        levelIsAvailable8 = PlayerPrefs.GetInt("LevelIsAvailable8");
        if (levelIsAvailable8 == 1)
        {
            ButtonLoad8.interactable = true;
        }

        levelIsAvailable9 = PlayerPrefs.GetInt("LevelIsAvailable9");
        if (levelIsAvailable9 == 1)
        {
            ButtonLoad9.interactable = true;
        }

        levelIsAvailable10 = PlayerPrefs.GetInt("LevelIsAvailable10");
        if (levelIsAvailable10 == 1)
        {
            ButtonLoad10.interactable = true;
        }

        levelIsAvailable11 = PlayerPrefs.GetInt("LevelIsAvailable11");
        if (levelIsAvailable11 == 1)
        {
            ButtonLoad11.interactable = true;
        }

        levelIsAvailable12 = PlayerPrefs.GetInt("LevelIsAvailable12");
        if (levelIsAvailable12 == 1)
        {
            ButtonLoad12.interactable = true;
        }

        /*if (_levelComplete == 1)
        {
            ButtonLoad2.interactable = true;
            levelIsAvailable2 = 1;
            PlayerPrefs.SetInt("LevelIsAvilable2", levelIsAvailable2);
        }*/
    }
    public void LoadLevel(int Level)
    {
        SceneManager.LoadScene(Level);
    }



}
