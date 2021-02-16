using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_interactable : MonoBehaviour
{
    public GameObject diapasontrigger;
    public GameObject cavas;
    private void OnTriggerEnter(Collider other)
    {
        cavas.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        cavas.SetActive(false);
    }

    void attivaCollider() 
    {
        diapasontrigger.GetComponent<Collider>().enabled = true;
    }

}
