using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Prtl : MonoBehaviour
{
    
    public void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().name == "GameScene")
        {

            SceneManager.LoadScene("MenuScene");
        
        }
    }

    
    public void GoToGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void ExitToGame() 
    {
        Application.Quit();

    }
}
