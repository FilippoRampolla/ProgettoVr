using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class indicazioni : MonoBehaviour


{

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    

    public GameObject camera;
    public GameObject fps;
    public GameObject continueButton;
    public GameObject start;
    public GameObject inv;


    private void OnTriggerEnter(Collider other)
    {

        StartCoroutine(Type());
        inv.SetActive(false);
        start.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        fps.SetActive(false);
        camera.SetActive(true);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
       
    
     }  
    
    void Update()
    {
       
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);

        }
    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }
    }
    // Update is called once per frame

    public void NextSentences()
    {
        continueButton.SetActive(false);

        if(index< sentences.Length-1)

        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        } else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            start.SetActive(false);
            fps.SetActive(true);
            camera.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            inv.SetActive(true) ;


        }
    }

    
}
