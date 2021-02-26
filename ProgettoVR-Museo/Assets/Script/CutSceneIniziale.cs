﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneIniziale : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject cutsceneCam;
    public GameObject light;

    private void Start()
    {
        cutsceneCam.SetActive(true);
        ThePlayer.SetActive(false);
        StartCoroutine(FinishCut());
    }
    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(50);
        ThePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
    }
    IEnumerator Offlight()
    {
        yield return new WaitForSeconds(25);
        light.SetActive(false);

    }
}
