using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour {

    public GameObject animator;
    public void Playgame()

    {
        FadeTolevel();
        SceneManager.LoadScene("SampleScene");
    }
    public void Quitgame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

 public void FadeTolevel ()
    {
        animator.GetComponent<Animator>().SetTrigger("fadeout");
    }

}

