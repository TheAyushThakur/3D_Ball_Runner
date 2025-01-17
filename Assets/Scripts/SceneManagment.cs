using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
   public void MenuchangeScene()
    {  
            SceneManager.LoadScene("MainMenuScene");
    }
    public void MainmenuchangeScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void QuitGame()
    {
        Debug.Log("You have exit the game!!");
        Application.Quit();
     
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Mainscene");
    }
}
