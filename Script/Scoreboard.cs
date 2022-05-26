using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour
{
    public static int totalScore = 0;
    

    private void OnGUI()
    {
        
        GUI.skin.box.fontSize = 30;
        GUI.color = Color.green;
        GUI.Box(new Rect(100, 150, 300, 50), "Score = " + totalScore.ToString());
    }

    void Update()
    {
        if(Scoreboard.totalScore == 15)
        {
            SceneManager.LoadScene(3);
        }
    }
}
