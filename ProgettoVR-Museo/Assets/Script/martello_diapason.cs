using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class martello_diapason : MonoBehaviour

{


    public GameObject sfera;
    private void OnTriggerEnter(Collider other)
    {
        sfera.GetComponent<Collider>().enabled = true;
        Debug.Log("cisono");
     }
    //private void OnCollisionEnter(Collision collisioninfo)
    //{
     //   if (collisioninfo.collider.tag == "diapason"){
      //      sfera.GetComponent<Collider>().enabled = true;
        //}
    

}