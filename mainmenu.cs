using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
   void Start() 
   {
      if (SceneManager.GetActiveScene().name != "Main menu")
       {
            SceneManager.LoadScene("Main menu");
        }

   }
   public void PlayGame()
   {
    SceneManager.LoadSceneAsync("Evil Hunt");
    

   }

   public void ControlPage()
   {
    SceneManager.LoadSceneAsync("controls");
    

   }

   public void QuitGame()
   {
      Application.Quit();
   }
}
