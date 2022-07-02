using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] public GameObject _chooseLevel;

    [SerializeField] GameObject _optionMenu;
    public void LevelChoose()
    {
        _chooseLevel.SetActive(true);
    }

    public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }

    public void OpenOption()
    {
        _optionMenu.SetActive(true);
    }
    public void CloseOption()
    {
        _optionMenu.SetActive(false);
    }
}