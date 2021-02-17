﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BellAnim : MonoBehaviour
{
    public GameObject radio;
    public Button3D changeYPosButton;
    public GameObject Facoltativo;

    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject trigger3;
    public GameObject trigger4;

    public GameObject cam;
    public GameObject Fp;

    public GameObject Npcnew;
    public Transform pos;
    public GameObject Npc;
    public GameObject campan;
    void Start()
    {
        changeYPosButton.OnButtonPressed += OnChageYposButtonPressed;
    }
    private void OnChageYposButtonPressed()
    {
        
        var tween = transform.DOMoveY(2.3f , 5f);
        radio.SetActive(false);
        Facoltativo.SetActive(true);
        Destroy(Npc);
        Instantiate(Npcnew, pos.position, pos.rotation);
        cam.SetActive(true);
        Fp.SetActive(false);
        campan.GetComponent<DialogBell>().enabled = true;

        trigger1.GetComponent<Collider>().enabled = true;
        trigger2.GetComponent<Collider>().enabled = true;
        trigger3.GetComponent<Collider>().enabled = true;
        trigger4.GetComponent<Collider>().enabled = true;
    }

    
}
