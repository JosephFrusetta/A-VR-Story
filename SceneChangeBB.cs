using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeBB : MonoBehaviour
{
    public float waitBeforeNextScene = 2.0f;
    public FadeIn fadeInScript;
    public AudioClip scene0Audio;
    public AudioClip transitionBlip;
    private AudioSource audioSource;
    private bool buttonActive;

    // Start is called before the first frame update
    void Start()
    {
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource component attached to the GameObject.");
            return;
        }

        fadeInScript.StartFadeIn(); // Fades the black UI element so the initial scene becomes visible
        DynamicGI.UpdateEnvironment(); // Update the Global Illumination - GameObject lighting will update with the new skybox
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = scene0Audio;
        audioSource.Play();
        StartCoroutine(WaitToActivateButton());
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
        audioSource.PlayOneShot(transitionBlip);
        yield return new WaitForSeconds(waitBeforeNextScene); // Wait before loading the next scene
        SceneManager.LoadScene("GameScene1"); // Load next scene
    }
}