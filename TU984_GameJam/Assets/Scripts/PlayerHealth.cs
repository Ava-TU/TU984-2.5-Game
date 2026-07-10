using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 5;
    private int currentHealth;

    public HealthUI healthUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        healthUI.SetMaxHearts(maxHealth);
    }

    
}
