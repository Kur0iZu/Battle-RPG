using UnityEngine;
using UnityEngine.UI;

public class Invoker : MonoBehaviour
{

    public int maxHP = 10, atk = 5;
    private int currentHP;
    
    public Enemy enemy;
    private HealthBar hpBar;
    public GameObject hpPrefab;

    private Button attackButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hpBar = hpPrefab.GetComponentInChildren<HealthBar>();
        attackButton = hpPrefab.GetComponentInChildren<Button>();

        currentHP = maxHP;
        hpBar.SetMaxHealth(maxHP);
        attackButton.onClick.AddListener(() => Attack());
    }

    public void Attack()
    {
        enemy.TakeDamage(atk);
    }

    public void TakeDamage(int value)
    {
        currentHP -= value;
        hpBar.SetHealth(currentHP);
    }
}
