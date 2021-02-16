using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_interactable : MonoBehaviour
{
    public GameObject diapasontrigger;
    
    public GameObject cavas;
    public GameObject esperimento;
    private void OnTriggerEnter(Collider other)
    {
        cavas.SetActive(true);
        Debug.Log("dentrotrigger");
        esperimento.GetComponent<Diapason_experiment>().enabled = true;
        
        
    }
    private void OnTriggerExit(Collider other)
    {
        cavas.SetActive(false);
        
        
        esperimento.GetComponent<Diapason_experiment>().enabled = false;
    }

    

    void attivaCollider() 
    {
        diapasontrigger.GetComponent<Collider>().enabled = true;
    }

}
