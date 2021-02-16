using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DeactivateRadio : MonoBehaviour


{


    public GameObject radio;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Rigidbody>().DOPause();
        this.gameObject.GetComponent<Collider>().enabled = false;
    }
}
