using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class CheckpointController : MonoBehaviour
{
    public int checkpointNumber;

    public TextMesh checkpointPoints;
    //audio
    private AudioSource audioSource;
    public  AudioClip checkpointSound;



    void Start()
    {
        checkpointNumber = UnityEngine.Random.Range(1, 10);
        checkpointPoints.text = checkpointNumber.ToString();

        //Initialize audio
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // If audio source component is not present, add it
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.CheckpointReached(checkpointNumber);
            ScoreManager.instance.AddPoint(checkpointNumber);
            PlayCheckpointSound();
            gameObject.SetActive(false);
        }
    }

    void PlayCheckpointSound()
    {
        if (audioSource != null && checkpointSound != null)
        {
            UnityEngine.Debug.Log("Playing checkpoint sound.");
            audioSource.PlayOneShot(checkpointSound);
        }
        else
        {
            UnityEngine.Debug.LogWarning("AudioSource or AudioClip is not assigned."); 
        }
    }
}

