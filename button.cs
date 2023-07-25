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
    public Material Scene7;
    public Material Scene8;
    public Material Scene9;
    public Material Scene10;
    public Material Scene11;
    public Material Scene12;
    public Material Scene13;
    public Material Scene14;
    public Material Scene15;
    public Material Scene16;
    public Material Scene17;
    public Material Scene18;
    public Material Scene19;
    public Material Scene20;
    public Material Scene21;
    public Material Scene22;
    public Material Scene23;
    public Material Scene24;
    public Material Scene25;
    public Material Scene26;
    public Material Scene27;
    public Material Scene28;
    public Material Scene29;
    public Material Scene30;
    public Material Scene31;
    public Material Scene32;
    public Material Scene33;
    public Material Scene34;
    public Material Scene35;
    public Material Scene36;
    public Material Scene37;
    public Material Scene38;
    public Material Scene39;
    public Material Scene40;
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
    public FadeIn fadeInScript; // Assign the FadeIn script in the inspector


  
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource component attached to the GameObject. Please add one.");
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
            fadeInScript.StartFadeIn(); //Turns off black UI element so the initial scene is visbile.
            StartCoroutine(ChangeSkybox());
        }

    }

    IEnumerator ChangeSkybox()
    {
        if (audioSource != null && StoryAudio != null) //Play audio clip
        {
            audioSource.clip = StoryAudio;
            audioSource.Play();
        }
        yield return new WaitForSeconds(waitBeforeScene1); // Time to wait BEFORE new scene loads
        RenderSettings.skybox = Scene1; // Set the skybox to Scene1
        DynamicGI.UpdateEnvironment(); // Updates the Global Illumination
        yield return new WaitForSeconds(waitAfterScene1); // Time to wait AFTER new scene loads
 
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

        // RenderSettings.skybox = Scene7; //First end credits scene
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene8;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene9;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene10;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene11;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene12;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene13;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene14;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene15;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene16;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene17;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene18;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene19;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene20;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene21;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene22;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene23;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene24;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene25;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene26;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene27;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene28;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene29;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene30;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene31;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene32;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene33;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene34;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene35;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene36;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene37;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene38;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene39;
        // DynamicGI.UpdateEnvironment();
        // yield return new WaitForSeconds(wait2p5SecBeat);
        
        // RenderSettings.skybox = Scene40;
        // DynamicGI.UpdateEnvironment();
        // storyPlaying = false;
        // yield return new WaitForSeconds(15);
        // fadeInScript.StartFadeOut();
        // yield return new WaitForSeconds(2);
        // RenderSettings.skybox = Scene0;
    }
}
