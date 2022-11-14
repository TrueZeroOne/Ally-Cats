using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLivesCounter : MonoBehaviour
{
    public GameObject Life1;
    public GameObject Life2;
    public GameObject Life3;
    public GameObject Life4;
    public GameObject Life5;
    public GameObject Life6;
    public GameObject Life7;
    public GameObject Life8;
    public GameObject Life9;
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
        switch (life)
        {
            case 0:
                {
                    Life1.gameObject.SetActive(false);
                    Life2.gameObject.SetActive(false);
                    Life3.gameObject.SetActive(false);
                    Life4.gameObject.SetActive(false);
                    Life5.gameObject.SetActive(false);
                    Life6.gameObject.SetActive(false);
                    Life7.gameObject.SetActive(false);
                    Life8.gameObject.SetActive(false);
                    Life9.gameObject.SetActive(false);
                    break;
                }
            case 1:
                {
                    Life1.gameObject.SetActive(true);
                    Life2.gameObject.SetActive(false);
                    Life3.gameObject.SetActive(false);
                    Life4.gameObject.SetActive(false);
                    Life5.gameObject.SetActive(false);
                    Life6.gameObject.SetActive(false);
                    Life7.gameObject.SetActive(false);
                    Life8.gameObject.SetActive(false);
                    Life9.gameObject.SetActive(false);
                    break;
                }
            case 2:
                {
                    Life1.gameObject.SetActive(true);
                    Life2.gameObject.SetActive(true);
                    Life3.gameObject.SetActive(false);
                    Life4.gameObject.SetActive(false);
                    Life5.gameObject.SetActive(false);
                    Life6.gameObject.SetActive(false);
                    Life7.gameObject.SetActive(false);
                    Life8.gameObject.SetActive(false);
                    Life9.gameObject.SetActive(false);
                    break;
                }
            case 3:
                {
                    Life1.gameObject.SetActive(true);
                    Life2.gameObject.SetActive(true);
                    Life3.gameObject.SetActive(true);
                    Life4.gameObject.SetActive(false);
                    Life5.gameObject.SetActive(false);
                    Life6.gameObject.SetActive(false);
                    Life7.gameObject.SetActive(false);
                    Life8.gameObject.SetActive(false);
                    Life9.gameObject.SetActive(false);
                    break;
                }
            case 4:
                {
                    Life1.gameObject.SetActive(true);
                    Life2.gameObject.SetActive(true);
                    Life3.gameObject.SetActive(true);
                    Life4.gameObject.SetActive(true);
                    Life5.gameObject.SetActive(false);
                    Life6.gameObject.SetActive(false);
                    Life7.gameObject.SetActive(false);
                    Life8.gameObject.SetActive(false);
                    Life9.gameObject.SetActive(false);
                    break;
                }
            case 5:
                {
                    Life1.gameObject.SetActive(true);
                    Life2.gameObject.SetActive(true);
                    Life3.gameObject.SetActive(true);
                    Life4.gameObject.SetActive(true);
                    Life5.gameObject.SetActive(true);
                    Life6.gameObject.SetActive(false);
                    Life7.gameObject.SetActive(false);
                    Life8.gameObject.SetActive(false);
                    Life9.gameObject.SetActive(false);
                    break;
                }
            case 6:
                {
                    Life1.gameObject.SetActive(true);
                    Life2.gameObject.SetActive(true);
                    Life3.gameObject.SetActive(true);
                    Life4.gameObject.SetActive(true);
                    Life5.gameObject.SetActive(true);
                    Life6.gameObject.SetActive(true);
                    Life7.gameObject.SetActive(false);
                    Life8.gameObject.SetActive(false);
                    Life9.gameObject.SetActive(false);
                    break;
                }
            case 7:
                {
                    Life1.gameObject.SetActive(true);
                    Life2.gameObject.SetActive(true);
                    Life3.gameObject.SetActive(true);
                    Life4.gameObject.SetActive(true);
                    Life5.gameObject.SetActive(true);
                    Life6.gameObject.SetActive(true);
                    Life7.gameObject.SetActive(true);
                    Life8.gameObject.SetActive(false);
                    Life9.gameObject.SetActive(false);
                    break;
                }
            case 8:
                {
                    Life1.gameObject.SetActive(true);
                    Life2.gameObject.SetActive(true);
                    Life3.gameObject.SetActive(true);
                    Life4.gameObject.SetActive(true);
                    Life5.gameObject.SetActive(true);
                    Life6.gameObject.SetActive(true);
                    Life7.gameObject.SetActive(true);
                    Life8.gameObject.SetActive(true);
                    Life9.gameObject.SetActive(false);
                    break;
                }
            case 9:
                {
                    Life1.gameObject.SetActive(true);
                    Life2.gameObject.SetActive(true);
                    Life3.gameObject.SetActive(true);
                    Life4.gameObject.SetActive(true);
                    Life5.gameObject.SetActive(true);
                    Life6.gameObject.SetActive(true);
                    Life7.gameObject.SetActive(true);
                    Life8.gameObject.SetActive(true);
                    Life9.gameObject.SetActive(true);
                    break;
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
        life -= lives;
    }
    
}
