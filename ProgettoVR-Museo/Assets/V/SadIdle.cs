using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadIdle : MonoBehaviour
{
    public GameObject NPC;
    

    private void OnTriggerEnter(Collider other)
    {
        NPC.GetComponent<Animation>().Play("Sad Idle");
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
