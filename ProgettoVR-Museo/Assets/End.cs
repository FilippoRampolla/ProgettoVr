using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{

    public GameObject canvas;
    public GameObject audio;
    private void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
        audio.GetComponent<AudioSource>().enabled = true;
    }
}
