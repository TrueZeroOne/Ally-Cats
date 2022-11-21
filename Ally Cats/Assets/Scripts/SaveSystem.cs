using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SaveSystem : MonoBehaviour
{
    public string playerHealthKey = "Playerhealth", playerLivesKey = "PlayerLives", sceneKey = "SceneIndex", savePresentKey = "SavePresent";

    public LoadedData LoadedData { get; private set; }

    public UnityEvent<bool> OnDataLoadedResult;

    

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        
        var result = LoadData();
        OnDataLoadedResult?.Invoke(result);
       
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteKey(playerHealthKey);
        PlayerPrefs.DeleteKey(sceneKey);
        PlayerPrefs.DeleteKey(playerLivesKey);
        PlayerPrefs.DeleteKey(savePresentKey);
        LoadedData = null;

    }

    public bool LoadData()
    {
        if(PlayerPrefs.GetInt(savePresentKey) == 1)
        {
            LoadedData = new LoadedData();
            LoadedData.playerHealth = PlayerPrefs.GetInt(playerHealthKey);
            LoadedData.playerLives = PlayerPrefs.GetInt(playerLivesKey);
            LoadedData.sceneIndex = PlayerPrefs.GetInt(sceneKey);
            return true;
        }
        return false;
    }

    public void SaveData(int sceneIndex, int playerHealth, int playerLives)
    {
        if (LoadedData == null)
            LoadedData = new LoadedData();
        LoadedData.playerHealth = playerHealth;
        LoadedData.playerLives = playerLives;
        LoadedData.sceneIndex = sceneIndex;       
        PlayerPrefs.SetInt(playerHealthKey, playerHealth);
        PlayerPrefs.SetInt(playerLivesKey, playerLives);
        PlayerPrefs.SetInt(sceneKey, sceneIndex);
        PlayerPrefs.SetInt(savePresentKey, 1);
    }
}

public class LoadedData
{
    public int playerHealth = -1;
    public int playerLives = -1;
    public int sceneIndex = -1;
}
