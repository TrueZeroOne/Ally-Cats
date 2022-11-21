using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour
{
    public GameObject player;
    public SaveSystem saveSystem;
    

    private void Awake()
    {
        SceneManager.sceneLoaded += Initialize;
        DontDestroyOnLoad(gameObject);
    }

    private void Initialize(Scene scene, LoadSceneMode sceneMode)
    {
        var playeInput = FindObjectOfType<movement>();
        if(playeInput != null)
            player = playeInput.gameObject;
        saveSystem = FindObjectOfType<SaveSystem>();
        if(player != null && saveSystem.LoadedData != null)
        {
            var health = player.GetComponent<Player_Health>();
            health.currentHealth = saveSystem.LoadedData.playerHealth;
            var lives = player.GetComponent<PlayerLivesCounter>();
            lives.life = saveSystem.LoadedData.playerLives;

        }
    }

    public void LoadLeve()
    {
        if(saveSystem.LoadedData != null)
        {
            SceneManager.LoadScene(saveSystem.LoadedData.sceneIndex);
            return;
        }
        LoadNextLevel();
    }


    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SaveData()
    {
        if (player != null)
            saveSystem.SaveData(SceneManager.GetActiveScene().buildIndex + 1, 
                player.GetComponentInChildren<Player_Health>().currentHealth, 
                player.GetComponentInChildren<PlayerLivesCounter>().life);
    }

}
