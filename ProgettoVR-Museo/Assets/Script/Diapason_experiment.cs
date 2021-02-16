using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diapason_experiment : MonoBehaviour
{

    public GameObject fps;
    public GameObject camera;
    public GameObject cavas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            camera.SetActive(true);
            cavas.SetActive(false);
            fps.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if(Input.GetKeyDown("e"))
        {
            cavas.SetActive(true);
            fps.SetActive(true);
            camera.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }


    }
}
