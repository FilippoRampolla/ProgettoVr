using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fadequit : MonoBehaviour
{
    public Animator animator;
    private int levelToload;

    private void OnTriggerEnter(Collider other)
    {
        FadeToLevel(0);
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToload = levelIndex;
        animator.SetTrigger("out");
    }

    public void OnFadeCOmplete()
    {
        SceneManager.LoadScene(levelToload);
    }
}
