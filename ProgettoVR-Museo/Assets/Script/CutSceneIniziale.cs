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

    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("sottofondo");
        cutsceneCam.SetActive(true);
        ThePlayer.SetActive(false);
        StartCoroutine(FinishCut());
        StartCoroutine(Offlight());
    }
    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(50);
        ThePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
        canva.SetActive(true);
    }
    IEnumerator Offlight()
    {
        yield return new WaitForSeconds(26);
        light.SetActive(false);
        soundClock.GetComponent<AudioSource>().enabled = true;
        
    }
}
