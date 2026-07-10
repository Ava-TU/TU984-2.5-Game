using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 5;
    public int currentHealth;
    private int damage = 1;

    public HealthUI healthUI;
    public PlayerController playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        healthUI.SetMaxHearts(maxHealth);
    }

    void Update()
    {
        if (playerController.playerHit == true)
        {
            TakeDamage(damage);
            playerController.playerHit = false;
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthUI.UpdateHearts(currentHealth);

        if (currentHealth <= 0)
        {
            //player loses - game over screen
        }
    }
}
