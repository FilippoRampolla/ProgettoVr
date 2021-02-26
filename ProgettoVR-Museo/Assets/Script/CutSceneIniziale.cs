using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneIniziale : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject cutsceneCam;
    public GameObject light;
    public GameObject canva;
    public GameObject soundClock;

    public GameObject target;
    public GameObject inventory;

    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("sottofondo");
        cutsceneCam.SetActive(true);
        ThePlayer.SetActive(false);
        StartCoroutine(FinishCut());
        StartCoroutine(Offlight());
        StartCoroutine(ding());
    }
    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(50);
        ThePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
        canva.SetActive(true);
        target.SetActive(true);
        inventory.SetActive(true);
    }
    IEnumerator Offlight()
    {
        yield return new WaitForSeconds(25);
        light.SetActive(false);
        
        
    }
    IEnumerator ding()
    {
        yield return new WaitForSeconds(22);
      
        soundClock.GetComponent<AudioSource>().enabled = true;

    }
}
