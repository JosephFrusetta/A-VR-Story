using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeBB : MonoBehaviour
{
    public float waitBeforeNextScene = 3.0f;
    public FadeIn fadeInScript;
    public AudioClip Scene0Audio;
    private AudioSource audioSource;
    private bool buttonActive = false;

    // Start is called before the first frame update
    void Start()
    {
        fadeInScript.StartFadeIn(); // Fades the black UI element so the initial scene becomes visible
        DynamicGI.UpdateEnvironment(); // Update the Global Illumination - GameObject lighting will update with the new skybox
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Scene0Audio;
        audioSource.Play();
        StartCoroutine(WaitToActivateButton());
        
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
        if (buttonActive)
        {
            StartCoroutine(ChangeScene());
        }
    }
    
    IEnumerator WaitToActivateButton()
    {
        yield return new WaitForSeconds(2);
        buttonActive = true; // Allow button to be activated after 2 seconds.
    }
    
    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(waitBeforeNextScene); // Wait before loading the next scene
        audioSource.Stop(); // Stops all audio from playing
        SceneManager.LoadScene("GameScene1"); // Load next scene
    }
    }
}