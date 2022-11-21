using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{
    public int iLevelToLoad;
    public string sLevelToLoad;
    

    public bool useIntegerToLoadLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        GameObject CollisionGameObject = collision.gameObject;

        if(CollisionGameObject.name == "Player") 
        {
            LoadScene();
        }

    }

    public void LoadScene()
    {
        if (useIntegerToLoadLevel)
        {
            SceneManager.LoadScene(iLevelToLoad);
        }
        else
        {
            SceneManager.LoadScene(sLevelToLoad);
        }
    }


}
