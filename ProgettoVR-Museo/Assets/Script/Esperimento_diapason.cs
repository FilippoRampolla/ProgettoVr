using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esperimento_diapason : MonoBehaviour
{

    public GameObject diapason;
    private Transform posizioneD;
    private Transform posizioneM;
    public GameObject martello;
    private Transform posizioneS;
    public GameObject sfera;

    // Start is called before the first frame update
    void Start()
    {

        posizioneD = diapason.transform;
        posizioneM = martello.transform;
        posizioneS = sfera.transform;
    }


    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(diapason, posizioneD.position, posizioneD.rotation);
            Instantiate(martello, posizioneM.position, posizioneM.rotation);
            Instantiate(sfera, posizioneS.position, posizioneS.rotation);

        }
    }

    


}