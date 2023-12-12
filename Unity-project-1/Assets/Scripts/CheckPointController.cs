using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckpointController : MonoBehaviour
{
    public int checkpointNumber;





    void Start()
    {
        checkpointNumber = UnityEngine.Random.Range(6, 12);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.CheckpointReached(checkpointNumber);
            ScoreManager.instance.AddPoint();
            gameObject.SetActive(false);
        }
    }
}

