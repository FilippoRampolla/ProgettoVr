using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class PhysicsGrabbable : Grabbable
{
    private Rigidbody _rigidbody;
    private Collider _collider;


    public GameObject button;
    public GameObject luci;
    public GameObject canva;

    protected override void Start ()
    {
        base.Start();
        _collider = GetComponent<Collider>();
        _rigidbody = GetComponent<Rigidbody>();
       

    }

    public override void Grab(GameObject grabber)
    {
        _collider.enabled = false;
        _rigidbody.isKinematic = true;
        GetComponent<Rigidbody>().DOPause();
        button.GetComponent<Button3D>().enabled = true;
        button.GetComponent<Button3DInteractable>().enabled = true;
        luci.SetActive(true);
        canva.SetActive(true);


    }

    public override void Drop()
    {
        _collider.enabled = true;
        _rigidbody.isKinematic = false;
        
    }
}
