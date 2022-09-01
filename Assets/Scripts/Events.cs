using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
    
    private void Start() {
        Time.timeScale = 1;
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(0);
    }
     public void ReplayGame1()
    {
        SceneManager.LoadScene(1);
    }
     public void ReplayGame2()
    {
        SceneManager.LoadScene(2);
    }


    public void QuitGame()
    {
        SceneManager.LoadScene(4);
    }
      public void QuitGame1()
    {
        SceneManager.LoadScene(4);
    }
      public void QuitGame2()
    {
        SceneManager.LoadScene(4);
    }
    


}

