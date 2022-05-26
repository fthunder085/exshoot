using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{

    public float life = 3;
    

    
    // Start is called before the first frame update
    void Awake()
    {
        Destroy(gameObject, life);
    }

    // Update is called once per frame
    /**void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Respawn")
        {
            Destroy(collision.transform.gameObject);
            
            Scoreboard.totalScore += 1; //menambah skor
        }
        //Destroy(collision.gameObject);
        //Destroy(gameObject); //menghilangkan objek musuh
        
    }**/

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
        Scoreboard.totalScore += 1;
    }

    

    

    
}
