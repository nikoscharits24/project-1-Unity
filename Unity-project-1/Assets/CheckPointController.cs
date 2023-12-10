using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckpointController : MonoBehaviour
{
    public int checkpointNumber;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.CheckpointReached(checkpointNumber);
            gameObject.SetActive(false); // Disable the checkpoint once it's reached
        }
    }
}

