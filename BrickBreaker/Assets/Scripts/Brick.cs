using UnityEngine;

public class Brick : MonoBehaviour
{
    public BrickData brickData;

    private int currentHealth;

    private void Start()
    {
        currentHealth = brickData.health;
        GetComponent<Renderer>().material.color = brickData.brickColor;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            DestroyBrick();
        }
    }

    private void DestroyBrick()
    {
        // Play destruction effect
        Instantiate(brickData.destructionEffect, transform.position, Quaternion.identity);

        // Destroy the brick game object
        Destroy(gameObject);
    }
}