using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadIdle : MonoBehaviour
{
    public GameObject NPC;
    void Update()
    {
        NPC.GetComponent<Animation>().Play("Sad Idle");
    }

    
}
