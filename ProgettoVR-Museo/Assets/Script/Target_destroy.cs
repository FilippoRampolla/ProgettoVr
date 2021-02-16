using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_destroy : MonoBehaviour
{

    public GameObject sprite_patate;
    public GameObject sprite_chiodi;
    public GameObject sprite_wire;
    public void Destory()
    {
        Destroy(gameObject);
        sprite_patate.GetComponent<ItemSlot>().enabled = true;
        sprite_chiodi.GetComponent<ItemSlot>().enabled = true;
        sprite_wire.GetComponent<ItemSlot>().enabled = true;
    }
}
