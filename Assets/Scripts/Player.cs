using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    
    public HealthBar healthBar;
    public Button damageButton;

    void Start()
    {
        maxHealth = 20;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
       
    }

    public void TakeDamage(int value)
    {
        currentHealth -= value;
        healthBar.SetHealth(currentHealth);
    }
}
