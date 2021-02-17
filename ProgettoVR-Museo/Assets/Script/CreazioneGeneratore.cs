using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreazioneGeneratore : MonoBehaviour
{
   
    public GameObject camera;
    public GameObject fps;
    
    private int flag = 0;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            if (flag == 0)
            {
               
                
                // Debug.Log("in");
            }
            else
            {
                camera.SetActive(true);
                fps.SetActive(true);
                flag = 0;

                // Debug.Log("out");
            }
        }

    }
}
