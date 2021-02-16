using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_interactable : MonoBehaviour
{
    public GameObject diapasontrigger;
    public GameObject testo_exit;
    public GameObject testo_int;
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
        testo_exit.SetActive(false);
        testo_int.SetActive(true);
        esperimento.GetComponent<Diapason_experiment>().enabled = false;
    }

    private void update()
    {
        if (Input.GetKeyDown("i"))
        {
            testo_exit.SetActive(true);
            testo_int.SetActive(false);
        }
    }
    void attivaCollider() 
    {
        diapasontrigger.GetComponent<Collider>().enabled = true;
    }

}
