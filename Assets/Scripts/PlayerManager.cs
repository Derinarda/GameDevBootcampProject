using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   public static bool gameOver;
   public GameObject gameoverPanel;
   public static bool isGameStarted;
   public GameObject startingText;

private void Start() 
{
   gameOver = false;   
   isGameStarted =false;
}

void Update()
{
   if(gameOver)
   {
      Time.timeScale = 1;
      gameoverPanel.SetActive(true);
   }

   if(SwipeManager.tap)
   {
      isGameStarted = true;
      Destroy(startingText);

   }
}



}
