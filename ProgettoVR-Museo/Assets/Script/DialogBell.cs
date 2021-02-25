using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogBell : MonoBehaviour
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

    

    public GameObject invent;
    public GameObject NPCnew;

    //private void OnTriggerEnter(Collider other)
    //{
    private void Start()
    {


        StartCoroutine(Type());
        start.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        NPC.GetComponent<Animation>().CrossFadeQueued("Talking1");
        invent.SetActive(false);
    }
    // }  

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

        if (index < sentences.Length - 1)

        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
            NPC.GetComponent<Animation>().Play("Talking");
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            start.SetActive(false);

            // fps.GetComponent<FirstPersonCharacterController>().enabled = true;
            fps.SetActive(true);
            cam.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            NPC.transform.position = Vector3.Lerp(NPC.transform.position, pos.position, Time.time);

            invent.SetActive(true);


            


        }

    }
}
