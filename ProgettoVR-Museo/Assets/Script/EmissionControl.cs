using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionControl : MonoBehaviour
{

    public Material bulb;
    public Material wire;
    // Start is called before the first frame update
    void Start()
    {
        bulb.EnableKeyword("_EMISSION");
        wire.EnableKeyword("_EMISSION");
    }

    // Update is called once per frame
    void Update()
    {
       ;
    }
}
