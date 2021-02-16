using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diapason_experiment : MonoBehaviour
{

    public GameObject fps;
    public GameObject camera;
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
            fps.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }
}
