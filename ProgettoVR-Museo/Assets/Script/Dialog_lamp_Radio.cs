using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog_lamp_Radio : MonoBehaviour


{

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject NPC;
    public Transform pos;

    
    public GameObject fps;
    public GameObject continueButton;
    public GameObject start;
    public GameObject cam;

    public GameObject Trigger1;
    public GameObject Trigger2;
    

    public GameObject invent;
    public GameObject NPCnew;
    public GameObject radio;

    
    private void Start()
    {
        
    
    StartCoroutine(Type());
        start.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        NPC.GetComponent<idleLamp>().enabled = false;
        //fps.GetComponent<FirstPersonCharacterController>().enabled = false;
        //this.gameObject.GetComponent<BoxCollider>().enabled = false;
        NPC.GetComponent<Animation>().Play("Stand");
        invent.SetActive(false);
        radio.GetComponent<AudioSource>().enabled = true;
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
            NPC.GetComponent<Animation>().Play("Talking");
        } else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            start.SetActive(false);
            
            
            fps.SetActive(true);
            cam.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            // Destroy(NPC);
            NPC.transform.position = Vector3.Lerp(NPC.transform.position, pos.position, Time.time);
            //Instantiate(NPCnew, pos.position, pos.rotation);

            invent.SetActive(true);

            NPC.GetComponent<NPCFollow>().enabled = true;
            
            NPC.GetComponent<Animator>().enabled = true;


            Trigger1.GetComponent<Collider>().enabled = true;
            Trigger2.GetComponent<Collider>().enabled = true;

            
            


        }

    }

    
}
