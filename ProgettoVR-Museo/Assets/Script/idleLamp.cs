using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleLamp : MonoBehaviour
{


    public GameObject Npc;
    

    // Update is called once per frame
    void Update()
    {
        Npc.GetComponent<Animation>().Play("idleWait");
        Debug.Log("ci sono");
    }
}
