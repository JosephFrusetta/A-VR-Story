using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image blackScreen; // Assign the UI Image in the inspector
    public float fadeDuration = 2.0f; // The duration of the fade in seconds

    public void StartFadeIn()
    {
        // Start the fade-in effect
        StartCoroutine(FadeInCoroutine());
    }

    public void StartFadeOut()
    {
        // Start the fade-out effect
        StartCoroutine(FadeOutCoroutine());
    }
    
    public void StartFadeTransition(float waitTime = 2.5f)
    {
        // Start the fade-out, wait, then fade-in sequence
        StartCoroutine(FadeTransitionCoroutine(waitTime));
    }

    IEnumerator FadeTransitionCoroutine(float waitTime)
    {
        // First, fade out
        yield return StartCoroutine(FadeOutCoroutine());
        
        // Then, wait for the specified time
        yield return new WaitForSeconds(waitTime);
        
        // Finally, fade in
        yield return StartCoroutine(FadeInCoroutine());
    }

    IEnumerator FadeInCoroutine()
    {
        // Initial alpha value (completely opaque)
        float alpha = 1.0f;
        
        // Calculate the rate of fading (alpha change per second)
        float fadeRate = 1.0f / fadeDuration;

        // While the image is not fully transparent
        while (alpha > 0.0f)
        {
            // Decrease the alpha value
            alpha -= fadeRate * Time.deltaTime;
            
            // Set the new alpha value
            Color newColor = new Color(0, 0, 0, alpha);
            blackScreen.color = newColor;
            
            // Wait for the next frame
            yield return null;
        }
    }

    IEnumerator FadeOutCoroutine()
    {
        // Initial alpha value (completely transparent)
        float alpha = 0.0f;
        
        // Calculate the rate of fading (alpha change per second)
        float fadeRate = 1.0f / fadeDuration;

        // While the image is not fully opaque
        while (alpha < 1.0f)
        {
            // Increase the alpha value
            alpha += fadeRate * Time.deltaTime;
            
            // Set the new alpha value
            Color newColor = new Color(0, 0, 0, alpha);
            blackScreen.color = newColor;
            
            // Wait for the next frame
            yield return null;
        }
    }
}