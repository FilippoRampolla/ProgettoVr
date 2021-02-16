using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject inv;
    public GameObject camera;
    public GameObject fps;
    private int flag=0;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k") )
        {
            if (flag == 0) { 
            camera.SetActive(true);
            fps.SetActive(false);
            inv.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            flag = 1;
           // Debug.Log("in");
            }
            else
            {
                camera.SetActive(false);
                fps.SetActive(true);
                inv.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                flag = 0;
               // Debug.Log("out");
            }
        }
        
    }
}
