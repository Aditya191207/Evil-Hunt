using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controls : MonoBehaviour
{
    public void BackButton()
   {
    SceneManager.LoadSceneAsync("Main menu");
    
   }
 }

