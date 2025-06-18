using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int maxHP = 20, atk = 2;
    private int currentHP;
    
    public Invoker invoker;
    public Rogue rogue;
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
        int rand = UnityEngine.Random.Range(0, 2);

        if (rand == 0)
        {
            invoker.TakeDamage(atk);
        }
        else
        {
            rogue.TakeDamage(atk);
        }
    }

    public void TakeDamage(int value)
    {
        currentHP -= value;
        hpBar.SetHealth(currentHP);
    }
}
