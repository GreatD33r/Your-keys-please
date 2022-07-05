using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public bool PauseGame;
    public GameObject pauseGameMenu;

    [SerializeField] GameObject _optionMenu;
    [SerializeField] AudioSource[] _music;
    //[SerializeField] AudioSource[] _sound;
    [SerializeField] Slider musicSlider;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;

        for (int i = 0; i < _music.Length; i++)
        {
            _music[i].volume = musicSlider.value;
        }
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;

        for (int i = 0; i < _music.Length; i++)
        {
            _music[i].volume = 0;
        }
    }
    
    public void OptionOn()
    {
        _optionMenu.SetActive(true);
    }

    public void loadMenu()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Menu");
        }

    public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }

    public void ClearSave()
    {
        PlayerPrefs.DeleteKey("LevelComplete");
    }

}
