using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeBB : MonoBehaviour
{
    public float waitBeforeScene1 = 3.0f;
    public FadeIn fadeInScript;
    public AudioClip Scene0Audio;
    private AudioSource audioSource;
    private bool buttonActive = false;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Scene0Audio;
        audioSource.Play();

        if (audioSource == null)
        {
            Debug.LogError("No AudioSource component attached to the GameObject.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonActivate()
    {
        audioSource.Stop(); // Stops all audio from playing
        fadeInScript.StartFadeIn(); // Fades the black UI element so the initial scene becomes visible
        StartCoroutine(WaitToActivateButton());  

        if (buttonActive == true)
        {
            StartCoroutine(ChangeScene());  
        }
    }

    IEnumerator WaitToActivateButton()
    {
        yield return new WaitForSeconds(3); // Wait 3 seconds
        buttonActive = true; // Allow button to be activated after x seconds. This prevents accidental scene selections.
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(waitBeforeScene1); // Wait before loading the next scene
        SceneManager.LoadScene("GameScene1"); // Auto load next scene
    }
}