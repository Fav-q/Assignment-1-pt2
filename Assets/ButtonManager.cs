using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

     public void NewGameBtn(string newGameLevel)
     {
        SceneManager.LoadScene(newGameLevel);      
     }


    public void NewGameBtn()
    {
        Application.Quit();
    }

}
