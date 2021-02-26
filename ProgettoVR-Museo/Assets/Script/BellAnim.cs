using System.Collections;
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

   
    public Transform pos;
    public GameObject Npc;
    public GameObject campan;
    public GameObject button;
    
    void Start()
    {
        changeYPosButton.OnButtonPressed += OnChageYposButtonPressed;
    }
    private void OnChageYposButtonPressed()
    {

        
        var tween = transform.DOMoveY(2.3f , 5f);
        radio.SetActive(false);
        Facoltativo.SetActive(true);
        Npc.GetComponent<NPCFollow>().enabled = false;
        Npc.GetComponent<Animator>().enabled = false;
        Npc.transform.position = Vector3.Lerp(Npc.transform.position, pos.position, Time.time);
        
        
        cam.SetActive(true);
        Fp.SetActive(false);
        campan.GetComponent<DialogBell>().enabled = true;
        button.SetActive(false);

        trigger1.GetComponent<Collider>().enabled = true;
        trigger2.GetComponent<Collider>().enabled = true;
        trigger3.GetComponent<Collider>().enabled = true;
        trigger4.GetComponent<Collider>().enabled = true;
    }

    
}
