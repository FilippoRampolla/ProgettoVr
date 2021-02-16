using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog_lamp : MonoBehaviour


{

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject NPC;

    public GameObject camera;
    public GameObject fps;
    public GameObject continueButton;
    public GameObject start;


    private void OnTriggerEnter(Collider other)
    {

        StartCoroutine(Type());
        start.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        fps.GetComponent<FirstPersonCharacterController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        NPC.GetComponent<Animation>().Play("Talking1");

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
            fps.GetComponent<FirstPersonCharacterController>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            NPC.GetComponent<NPCFollow>().enabled = true;

        }

    }

    
}
