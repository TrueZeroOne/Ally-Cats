using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public int startGame;
    public string sgamename;

    public bool useIntegerToLoadLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
