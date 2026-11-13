using UnityEngine;
using System;

public class PlayerHealth : MonoBehaviour
{
    public int maxhealth = 10;
    private int health;
    public event Action death;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddHealth(int healthToAdd)
    { 
        health += healthToAdd;
        if (health > maxhealth)
        { 
            health = maxhealth;
        }
        else if (health <= 0)
        {
            Die();
        }
        Debug.Log(health);
    }

    private void Die()
    {
        death?.Invoke();

    }

}
