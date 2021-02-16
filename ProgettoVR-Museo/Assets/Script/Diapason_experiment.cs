using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diapason_experiment : MonoBehaviour
{

    public GameObject fps;
    public GameObject camera;
    public GameObject cavas;

    public GameObject testo_exit;
    public GameObject testo_int;
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
            testo_exit.SetActive(true);
            testo_int.SetActive(false);
        }
        if(Input.GetKeyDown("e"))
        {
            cavas.SetActive(true);
            fps.SetActive(true);
            camera.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            testo_exit.SetActive(false);
            testo_int.SetActive(true);
        }


    }
}
