using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Canvas canvas;
    public Button continuar;
    public Button mainMenu;
    public Button sortir;

    private void Start()
    {
        canvas.gameObject.SetActive(false);
        continuar.onClick.AddListener(ContinuarClick);
        mainMenu.onClick.AddListener(MainMenuClick);
        sortir.onClick.AddListener(SortirClick);
    }

    private void SortirClick()
    {
        Application.Quit();
    }

    private void MainMenuClick()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void ContinuarClick()
    {
        if (canvas.gameObject.activeInHierarchy)
        {
            canvas.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("IN");
            if (!canvas.gameObject.activeInHierarchy)
                canvas.gameObject.SetActive(true);
        }
    }
}
