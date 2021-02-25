using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFollow : MonoBehaviour
{
    public GameObject ThePlayer;
    public float targetDistance;
    public float AllowedDistance = 3;
    public GameObject TheNPC;
    public float FollowSpeed;
    public RaycastHit Shot;


   
    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot));
        {
            targetDistance = Shot.distance;
            if (targetDistance > 1 || targetDistance<0.75)
            {
                FollowSpeed = 0.02f;
                TheNPC.GetComponent<Animator>().Play("Walking");
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(ThePlayer.transform.position.x, transform.position.y, ThePlayer.transform.position.z), FollowSpeed);
            }
            else
            {
                
                FollowSpeed = 0;
                TheNPC.GetComponent<Animator>().Play("Happy Idle");

            }
        }
        
    }
   
}
