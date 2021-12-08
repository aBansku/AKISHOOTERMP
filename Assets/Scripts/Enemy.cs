using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 50f;
    public GameObject enemy;
    public GameObject ground;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            spawn();
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);

    }
    private void spawn()
    {

        Vector3 pos = new Vector3(Random.Range(ground.transform.position.x + 50, ground.transform.position.x - 50), 6.84f, Random.Range(ground.transform.position.z + 35, ground.transform.position.z - 50));
        Instantiate(enemy, pos, Quaternion.identity);
        Debug.Log("dsa");
    }
}
