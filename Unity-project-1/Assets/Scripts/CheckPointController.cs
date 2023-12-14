using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class CheckpointController : MonoBehaviour
{
    public int checkpointNumber;
    int total;


    public Collider _collider;
    public Renderer _renderer;
    public GameObject pointsBoard;
    


    public TextMesh checkpointPoints;

    //audio
    private AudioSource audioSource;
    public AudioClip checkpointSound;

   



    void Start()
    {
        checkpointNumber = UnityEngine.Random.Range(1, 10);
        //total = total + checkpointNumber;
        checkpointPoints.text = checkpointNumber.ToString();

        //Initialize audio
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // If audio source component is not present, add it
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        //UnityEngine.Debug.Log(total);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.CheckpointReached(checkpointNumber);
            ScoreManager.instance.AddPoint(checkpointNumber);
            if (PlayCheckpointSound())
            {
                UnityEngine.Debug.Log("Closing all components...");
                //Collider
                _collider.enabled = false;
                //checkpoint renderer
                _renderer.enabled = false;
                //Points Board gameObject
                pointsBoard.SetActive(false);

                //Text gameObject
                checkpointPoints.gameObject.SetActive(false);

                

            }

        }

    }

    bool PlayCheckpointSound()
    {
        if (audioSource != null && checkpointSound != null)
        {
            UnityEngine.Debug.Log("Playing checkpoint sound.");
            //AudioSource.PlayClip(checkpointSound,);
            audioSource.PlayOneShot(checkpointSound);
            return true;
        }
        else
        {
            UnityEngine.Debug.LogWarning("AudioSource or AudioClip is not assigned.");
            return false; 
        }
    }
}

