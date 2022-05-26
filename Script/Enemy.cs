using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject theEnemey;
    public int xPos;
    public int yPos;
    
    public int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 15)
        {
             xPos = Random.Range(-12, 12); //kanan kiri
            yPos = Random.Range(-7, 4); //atas bawah
            
            Instantiate(theEnemey, new Vector3(xPos, yPos, 12), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }

    
}
