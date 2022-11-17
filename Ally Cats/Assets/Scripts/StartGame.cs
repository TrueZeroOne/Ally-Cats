using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public int startGame;
    public string sgamename;

    public bool useIntegerToLoadLevel;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartLvl();
        }
    }

    public void StartLvl()
    {
        if (useIntegerToLoadLevel)
        {
            SceneManager.LoadScene(startGame);
        }
        else
        {
            SceneManager.LoadScene(sgamename);
        }
    }
}
