using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Museum");

    }

    public void Menu()
    {
        SceneManager.LoadScene("Start");

    }

    public void Quit()
    {

        Application.Quit();

        Debug.Log("Has quitted");
        
    }





}
