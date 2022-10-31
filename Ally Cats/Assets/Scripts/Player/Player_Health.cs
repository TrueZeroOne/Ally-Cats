using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour
{
    public int maxHealth = 100;
    public Slider slider;
    public int currentHealth;
    public PlayerLivesCounter plc;


    public void Start()
    {
        currentHealth = maxHealth;
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        
         currentHealth =health;
        if(currentHealth <= 0)
        {
            plc.LoseLives(1);
            
        }

        
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        
        if (currentHealth <= 0)
        {
            currentHealth = maxHealth;
            plc.LoseLives(1);

        }
        slider.value = currentHealth;
    }

   

}
