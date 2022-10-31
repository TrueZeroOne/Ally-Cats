using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLivesCounter : MonoBehaviour
{
    public GameObject[] Lives;
    public int life;


    void Update()
    {
        if (life < 1)
        {
            Destroy(Lives[0].gameObject);
        }
        else if (life < 2)
        {
            Destroy(Lives[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(Lives[2].gameObject);
        }
        else if (life < 4)
        {
            Destroy(Lives[3].gameObject);
        }
        else if (life < 5)
        {
            Destroy(Lives[4].gameObject);
        }
        else if (life < 6)
        {
            Destroy(Lives[5].gameObject);
        }
        else if (life < 7)
        {
            Destroy(Lives[6].gameObject);
        }
        else if (life < 8)
        {
            Destroy(Lives[7].gameObject);
        }
        else if (life < 9)
        {
            Destroy(Lives[8].gameObject);
        }
        if(life < 0)
        {
            Destroy(gameObject);

        }
        
    }

    public void LoseLives(int d)
    {
        life -= d;
         
        
    }
}
