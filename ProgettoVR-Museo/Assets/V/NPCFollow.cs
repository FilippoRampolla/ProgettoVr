using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFollow : MonoBehaviour
{
    public GameObject ThePlayer;
    public float targetDistance;
    public float AllowedDistance = 5;
    public GameObject TheNPC;
    public float FollowSpeed;
    public RaycastHit Shot;
    public int flag = 0;
    
    
    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot));
        {
            targetDistance = Shot.distance;
            if (targetDistance >= AllowedDistance)
            {
                FollowSpeed = 0.02f;
                TheNPC.GetComponent<Animation>().Play("Walking");
                transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, FollowSpeed);
            }
            else
            {
                
                FollowSpeed = 0;
                TheNPC.GetComponent<Animation>().Play("Happy Idle");

            }
        }
        
    }
   
}
