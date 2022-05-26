using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerObjectDestructor : MonoBehaviour
{
    public float timeOut = 1.0f;
    public bool detachChildren = false;
    public float life = 3;

    void Awake()
    {
        Invoke ("DestroyNow", timeOut);
        Destroy(gameObject, life);
    }

    // Update is called once per frame
    void DestroyNow()
    {
        if (detachChildren)
        {
            transform.DetachChildren();
        }

        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
