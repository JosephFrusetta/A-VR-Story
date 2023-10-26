using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTracker : MonoBehaviour
{
    public PlayerData playerData;

    private static SceneTracker instance;
    public static SceneTracker Instance //Ensures actual Singleton instance remains private/encapsulated, but other classes can access through this.
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SceneTracker>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    instance = obj.AddComponent<SceneTracker>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        // Singleton pattern implementation
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;  // Register the event
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return; // Ensure the rest of the Awake method doesn't run for this duplicate
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        string currentScene = scene.name;

        if (currentScene == "GameScene2A" && playerData.HasVisitedScene("GameScene") && playerData.HasVisitedScene("GameScene1"))
        {
            Debug.Log("Success! You are in GameScene2A and you have visited both GameScene and GameScene1");
        }

        if (!playerData.HasVisitedScene(currentScene))
        {
            playerData.AddVisitedScene(currentScene);
            // Logic for first-time scene visit goes here
        }
        else
        {
            // Logic for scenes that have been visited before goes here
        }
    }

    private void OnDestroy()
    {
        // Make sure to unregister the event to avoid memory leaks
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}