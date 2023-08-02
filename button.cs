using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public Material Scene0;
    public Material Scene1;
    public Material Scene2;
    public Material Scene3;
    public Material Scene4;
    public Material Scene5;
    public Material Scene6;
    public float waitBeforeScene1 = 3.0f;
    public float waitAfterScene1 = 3.0f;
    public float waitAfterScene2 = 3.0f;
    public float waitAfterScene3 = 3.0f;
    public float waitAfterScene4 = 3.0f;
    public float waitAfterScene5 = 3.0f;
    public float waitAfterScene6 = 3.0f;
    public float wait2p5SecBeat = 3.0f;
    public AudioClip StoryAudio;
    private AudioSource audioSource;
    private bool storyPlaying = false;
    public FadeIn fadeInScript;


  
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource attached to the GameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonActivate()
    {
        if (storyPlaying == false)
        {
            storyPlaying = true;
            fadeInScript.StartFadeIn(); // Fades the black UI element so the initial scene becomes visible
            StartCoroutine(ChangeSkybox());
        }

    }

    IEnumerator ChangeSkybox()
    {
        if (audioSource != null && StoryAudio != null)
        {
            audioSource.clip = StoryAudio;
            audioSource.Play();
        }

        yield return new WaitForSeconds(waitBeforeScene1);
        RenderSettings.skybox = Scene1; // Set the skybox to Scene1
        DynamicGI.UpdateEnvironment(); // Update the Global Illumination - GameObject lighting will update with the new skybox
        yield return new WaitForSeconds(waitAfterScene1);
 
        RenderSettings.skybox = Scene2;
        DynamicGI.UpdateEnvironment();
        yield return new WaitForSeconds(waitAfterScene2);

        RenderSettings.skybox = Scene3;
        DynamicGI.UpdateEnvironment();
        yield return new WaitForSeconds(waitAfterScene3);

        RenderSettings.skybox = Scene4;
        DynamicGI.UpdateEnvironment();
        yield return new WaitForSeconds(waitAfterScene4);

        RenderSettings.skybox = Scene5;
        DynamicGI.UpdateEnvironment();
        yield return new WaitForSeconds(waitAfterScene5);

        RenderSettings.skybox = Scene6;
        DynamicGI.UpdateEnvironment();
        yield return new WaitForSeconds(waitAfterScene6);

        storyPlaying = false;
        fadeInScript.StartFadeOut();
        yield return new WaitForSeconds(3);
        RenderSettings.skybox = Scene0;
    }
}
