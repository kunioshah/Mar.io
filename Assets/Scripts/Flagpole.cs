using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flagpole : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entering flag collider");
        if (collision.tag == "Player")
        {

            StartCoroutine(PlayAnimation(5.7f));

        }
    }

    IEnumerator PlayAnimation(float delay)
    {
        GetComponent<Animator>().SetBool("isTouched", true);
        StopAllAudio();
        GetComponent<AudioSource>().Play();
        while (delay > 0)
        {
            delay -= Time.deltaTime;
            yield return null;
        }

        SceneManager.LoadScene("Win");
    }

    void StopAllAudio()
    {
        var allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }
}
