using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChooser : MonoBehaviour
{
    [SerializeField] private Button[] ButtonLoad;

    //[SerializeField] private Button ButtonLoad2;
    private int levelIsAvailable2 = 0;
    //[SerializeField] private Button ButtonLoad3;
    private int levelIsAvailable3 = 0;
    //[SerializeField] private Button ButtonLoad4;
    private int levelIsAvailable4 = 0;
    //[SerializeField] private Button ButtonLoad5;
    private int levelIsAvailable5 = 0;
    //[SerializeField] private Button ButtonLoad6;
    private int levelIsAvailable6 = 0;
    //[SerializeField] private Button ButtonLoad7;
    private int levelIsAvailable7 = 0;
    //[SerializeField] private Button ButtonLoad8;
    private int levelIsAvailable8 = 0;
    //[SerializeField] private Button ButtonLoad9;
    private int levelIsAvailable9 = 0;
    //[SerializeField] private Button ButtonLoad10;
    private int levelIsAvailable10 = 0;
    //[SerializeField] private Button ButtonLoad11;
    private int levelIsAvailable11 = 0;
    //[SerializeField] private Button ButtonLoad12;
    private int levelIsAvailable12 = 0;

    [SerializeField] private GameObject[] Lockimages;

    private int _levelComplete;

    private void Start()
    {

        /*ButtonLoad[0].interactable = false;
        ButtonLoad[1].interactable = false;
        ButtonLoad[2].interactable = false;
        ButtonLoad[3].interactable = false;
        ButtonLoad[4].interactable = false;
        ButtonLoad[5].interactable = false;
        ButtonLoad[6].interactable = false;
        ButtonLoad[7].interactable = false;
        ButtonLoad[8].interactable = false;
        ButtonLoad[9].interactable = false;
        ButtonLoad[10].interactable = false;*/

        _levelComplete = PlayerPrefs.GetInt("LevelComplete");


        switch (_levelComplete)
        {
            case 1:
                ButtonLoad[0].interactable = true;
                levelIsAvailable2 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable2", levelIsAvailable2);
                Lockimages[0].SetActive(false);
                break;
            case 2:
                ButtonLoad[1].interactable = true;
                levelIsAvailable3 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable3", levelIsAvailable3);
                Lockimages[1].SetActive(false);
                break;
            case 3:
                ButtonLoad[2].interactable = true;
                levelIsAvailable4 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable4", levelIsAvailable4);
                Lockimages[2].SetActive(false);
                break;
            case 4:
                ButtonLoad[3].interactable = true;
                levelIsAvailable5 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable5", levelIsAvailable5);
                Lockimages[3].SetActive(false);
                break;
            case 5:
                ButtonLoad[4].interactable = true;
                levelIsAvailable6 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable6", levelIsAvailable6);
                Lockimages[4].SetActive(false);
                break;
            case 6:
                ButtonLoad[5].interactable = true;
                levelIsAvailable7 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable7", levelIsAvailable7);
                Lockimages[5].SetActive(false);
                break;
            case 7:
                ButtonLoad[6].interactable = true;
                levelIsAvailable8 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable8", levelIsAvailable8);
                Lockimages[6].SetActive(false);
                break;
            case 8:
                ButtonLoad[7].interactable = true;
                levelIsAvailable9 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable9", levelIsAvailable9);
                Lockimages[7].SetActive(false);
                break;
            case 9:
                ButtonLoad[8].interactable = true;
                levelIsAvailable10 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable10", levelIsAvailable10);
                Lockimages[8].SetActive(false);
                break;
            case 10:
                ButtonLoad[9].interactable = true;
                levelIsAvailable11 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable11", levelIsAvailable11);
                Lockimages[9].SetActive(false);
                break;
            case 11:
                ButtonLoad[11].interactable = true;
                levelIsAvailable12 = 1;
                PlayerPrefs.GetInt("LevelIsAvailable12", levelIsAvailable12);
                Lockimages[10].SetActive(false);
                break;
            default:
                Debug.Log("Не прошел еще");
                break;
        }

        levelIsAvailable2 = PlayerPrefs.GetInt("LevelIsAvailable2");
        if (levelIsAvailable2 == 1)
        {
            ButtonLoad[0].interactable = true;
        }
        else
        {
            ButtonLoad[0].interactable = false;
        }

        levelIsAvailable3 = PlayerPrefs.GetInt("LevelIsAvailable3");
        if (levelIsAvailable3 == 1)
        {
            ButtonLoad[1].interactable = true;
        }
        else
        {
            ButtonLoad[1].interactable = false;
        }

        levelIsAvailable4 = PlayerPrefs.GetInt("LevelIsAvailable4");
        if (levelIsAvailable4 == 1)
        {
            ButtonLoad[2].interactable = true;
        }
        else
        {
            ButtonLoad[2].interactable = false;
        }

        levelIsAvailable5 = PlayerPrefs.GetInt("LevelIsAvailable5");
        if (levelIsAvailable5 == 1)
        {
            ButtonLoad[3].interactable = true;
        }
        else
        {
            ButtonLoad[3].interactable = false;
        }

        levelIsAvailable6 = PlayerPrefs.GetInt("LevelIsAvailable6");
        if (levelIsAvailable6 == 1)
        {
            ButtonLoad[4].interactable = true;
        }
        else
        {
            ButtonLoad[4].interactable = false;
        }

        levelIsAvailable7 = PlayerPrefs.GetInt("LevelIsAvailable7");
        if (levelIsAvailable7 == 1)
        {
            ButtonLoad[5].interactable = true;
        }
        else
        {
            ButtonLoad[5].interactable = false;
        }

        levelIsAvailable8 = PlayerPrefs.GetInt("LevelIsAvailable8");
        if (levelIsAvailable8 == 1)
        {
            ButtonLoad[6].interactable = true;
        }
        else
        {
            ButtonLoad[6].interactable = false;
        }

        levelIsAvailable9 = PlayerPrefs.GetInt("LevelIsAvailable9");
        if (levelIsAvailable9 == 1)
        {
            ButtonLoad[7].interactable = true;
        }
        else
        {
            ButtonLoad[7].interactable = false;
        }

        levelIsAvailable10 = PlayerPrefs.GetInt("LevelIsAvailable10");
        if (levelIsAvailable10 == 1)
        {
            ButtonLoad[8].interactable = true;
        }
        else
        {
            ButtonLoad[8].interactable = false;
        }

        levelIsAvailable11 = PlayerPrefs.GetInt("LevelIsAvailable11");
        if (levelIsAvailable11 == 1)
        {
            ButtonLoad[9].interactable = true;
        }
        else
        {
            ButtonLoad[9].interactable = false;
        }

        levelIsAvailable12 = PlayerPrefs.GetInt("LevelIsAvailable12");
        if (levelIsAvailable12 == 1)
        {
            ButtonLoad[10].interactable = true;
        }
        else
        {
            ButtonLoad[10].interactable = false;
        }
    }
    public void LoadLevel(int Level)
    {
        SceneManager.LoadScene(Level);
    }

}
