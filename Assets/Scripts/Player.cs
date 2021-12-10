using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float hp;
    private Vector3[] spawnPoints;
    public float spawnProtectionDuration = 5; // secs

    private void Start()
    {
        if (FindObjectOfType<GameManager>().getMap() == "1")
        {
            
        }
    }

    public void takeDamage(float damage)
    {
        hp -= damage;
        if (hp <= 0f)
        {

        }
    }

    private void die()
    {
        Destroy(gameObject);
    }

    private void respawn()
    {

    }


}
