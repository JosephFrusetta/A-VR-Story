using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ChooseYourAdventure/PlayerData", order = 0)]

public class PlayerData : ScriptableObject
{
    public List<string> visitedScenes = new List<string>();
    
    public void AddVisitedScene(string sceneName)
    {
        if (!visitedScenes.Contains(sceneName))
        {
            visitedScenes.Add(sceneName);
        }
    }

    public bool HasVisitedScene(string sceneName)
    {
        return visitedScenes.Contains(sceneName);
    }

}