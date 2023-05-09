using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _openMenuButton;
    [SerializeField] private GameObject _aboutUsView;
    [SerializeField] private GameObject[] _mainMenuButtons;
    [SerializeField] private UnityEvent _pausePlane;
    [SerializeField] private UnityEvent _playPlane;

    private void Start()
    {
        _mainMenu.SetActive(false);
        _aboutUsView.SetActive(false);
    }

    public void OpenMenu()
    {
        _mainMenu.SetActive(true);
        _openMenuButton.SetActive(false);
        _pausePlane.Invoke();
    }

    public void Play()
    {
        _openMenuButton.SetActive(true);
        _mainMenu.SetActive(false);
        _playPlane.Invoke();
    }

    public void ShowInfoAboutUs()
    {
        _aboutUsView.SetActive(true);
        HideButtons();
    }

    public void HideInfoAboutUs()
    {
        _aboutUsView.SetActive(false);
        ShowButtons();
    }

    public void ExitGame()
    {
        Debug.Log("Exit!");
    }

    private void HideButtons()
    {
        foreach(GameObject button in _mainMenuButtons)
        {
            button.SetActive(false);
        }
    }

    private void ShowButtons()
    {
        foreach(GameObject button in _mainMenuButtons)
        {
            button.SetActive(true);
        }
    }
}
