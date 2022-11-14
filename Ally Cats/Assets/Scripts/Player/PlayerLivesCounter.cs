using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLivesCounter : MonoBehaviour
{
    public GameObject[] Lives;
    public int life;


    public void Update()
    {
        if (life < 1)
        {
            Lives[0].gameObject.SetActive(false);
        }
        else if (life < 2)
        {
            Lives[1].gameObject.SetActive(false);
        }
        else if (life < 3)
        {
            Lives[2].gameObject.SetActive(false);
        }
        else if (life < 4)
        {
            Lives[3].gameObject.SetActive(false);
        }
        else if (life < 5)
        {
            Lives[4].gameObject.SetActive(false);
        }
        else if (life < 6)
        {
            Lives[5].gameObject.SetActive(false);
        }
        else if (life < 7)
        {
            Lives[6].gameObject.SetActive(false);
        }
        else if (life < 8)
        {
            Lives[7].gameObject.SetActive(false);
        }
        else if (life < 9)
        {
            Lives[8].gameObject.SetActive(false);
        }
        if(life < 0)
        {
           gameObject.SetActive(false);

        }

       
        
    }

    public void LoseLives(int d)
    {
        life -= d;
         
         
    }

    
}
