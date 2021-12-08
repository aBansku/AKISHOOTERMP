using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float hp;
    public void takeDamage(float damage)
    {
        hp -= damage;
        if (hp == 0f)
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
