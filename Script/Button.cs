using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
   public void pindahScene(int SceneID)
   {
       
       SceneManager.LoadScene(SceneID);
   }

   public void Back()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   }
}
