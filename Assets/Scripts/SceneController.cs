using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private Animator transition;
    [SerializeField] private AudioSource bgAudio;
    private static readonly int StartAnim = Animator.StringToHash("Start");

    private void Start()
    {
        StartCoroutine(FadeIn(bgAudio, 0.8f));
    }

    public void ResetScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex));
    }

    public void ExitApp()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    private IEnumerator LoadScene(int sceneIndex)
    {
        transition.SetTrigger(StartAnim);
        StartCoroutine(FadeOut(bgAudio, 0.8f));
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneIndex);
        StartCoroutine(FadeIn(bgAudio, 0.8f));
    }
    
    private static IEnumerator FadeOut(AudioSource audioSource, float fadeTime) {
        float startVolume = audioSource.volume;
        while (audioSource.volume > 0) {
            audioSource.volume -= startVolume * Time.deltaTime / fadeTime;
            yield return null;
        }
        audioSource.Stop();
    }

    private static IEnumerator FadeIn(AudioSource audioSource, float fadeTime) {
        audioSource.Play();
        audioSource.volume = 0f;
        while (audioSource.volume < 1) {
            audioSource.volume += Time.deltaTime / fadeTime;
            yield return null;
        }
    }
}
