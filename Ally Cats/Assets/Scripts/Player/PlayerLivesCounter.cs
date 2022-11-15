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
        /*switch (life)
        {
            case 0:
                {
                    for (int i = 0; i < Lives.Length; i++)
                    {
                        if (i >= life)
                        {
                            Lives[i].gameObject.SetActive(true);
                        }
                        else
                        {
                            Lives[i].gameObject.SetActive(false);
                        }
                    }
                    break;
                }
            case 1:
                {
                    Lives[1].gameObject.SetActive(true);
                    Lives[2].gameObject.SetActive(false);
                    Lives[3].gameObject.SetActive(false);
                    Lives[4].gameObject.SetActive(false);
                    Lives[5].gameObject.SetActive(false);
                    Lives[6].gameObject.SetActive(false);
                    Lives[7].gameObject.SetActive(false);
                    Lives[8].gameObject.SetActive(false);
                    Lives[9].gameObject.SetActive(false);
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
        }*/
        if(life == 0 && healthbar.currentHealth <= 0)
        {
            Debug.Log("Dead");
            Destroy(gameObject);
            
        }
    }

    public void LoseLives(int lives)
    {
        if(life >= Lives.Length)
        {
            life -= lives;
        }
    }
}
