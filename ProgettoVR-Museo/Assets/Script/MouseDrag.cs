using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{

    public float dragSpeed = 1f;
    Vector3 lastMousePos;

    private void OnMouseDown()
    {
        lastMousePos = Input.mousePosition;
    }

    private void OnMouseDrag()
    {
        Vector3 delta = Input.mousePosition - lastMousePos;
        Debug.Log(delta+ " "+ Input.mousePosition+ " "+lastMousePos);
        Vector3 pos = transform.position;
        pos.x += delta.x * dragSpeed;
        pos.y += delta.y * dragSpeed;
        
        transform.position = pos;
        lastMousePos = Input.mousePosition;
    }

   


}