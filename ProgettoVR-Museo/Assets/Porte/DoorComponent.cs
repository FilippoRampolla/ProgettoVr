﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorComponent : MonoBehaviour
{
    public GameObject instructions;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Door")
        {
            //instructions.SetActive(true);
            Animator anim = other.GetComponentInChildren<Animator>();
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetTrigger("OpenClose");
                FindObjectOfType<AudioManager>().Play("door");
            }
                


        }
    }
    private void OnTriggerExit(Collider other)
    {
       // if (other.tag == "Door")
        //{
            //instructions.SetActive(false);

        //}
    }
}