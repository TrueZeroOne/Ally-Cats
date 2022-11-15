using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLivesCounter : MonoBehaviour
{
    public GameObject[] Lives;

    public Player_Health healthbar;

    public int life;

    public void Start()
    {
       // healthbar = GetComponent<Player_Health>(); 
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            LoseLives(1);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            LoseLives(-1);
        }
        for (int i = 0; i < Lives.Length; i++)
        {
            if (i >= life)
            {
                Lives[i].gameObject.SetActive(false);
            }
            else
            {
                Lives[i].gameObject.SetActive(true);
            }
        }
        if(life == 0 && healthbar.currentHealth <= 0)
        {
            Debug.Log("Dead");
            Destroy(gameObject);
            
        }
    }

    public void LoseLives(int lives)
    {
        if(life - lives <=Lives.Length)
        {
            life -= lives;
        }

    }
}