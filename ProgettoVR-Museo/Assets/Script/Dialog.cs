using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour

  
{

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    private bool flag;

    public GameObject continueButton;
    public GameObject start;
    // Start is called before the first frame update

    
    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && flag==false)
        {
            StartCoroutine(Type());
            start.SetActive(true);
            flag = true;


        }
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
            flag = false;
        }
    }

    
}
