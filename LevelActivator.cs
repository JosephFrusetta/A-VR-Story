using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelActivator : MonoBehaviour
{
    public GameObject[] objectsToActivate;
    public string requiredSceneToVisit;

    private void Start()
    {
        if (SceneTracker.Instance.playerData.HasVisitedScene(requiredSceneToVisit))
        {
            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(true);
            }
        }
    }
}
