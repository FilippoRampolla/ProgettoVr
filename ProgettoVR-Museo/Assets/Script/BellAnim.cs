using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BellAnim : MonoBehaviour
{
    public GameObject radio;
    public Button3D changeYPosButton;
    public GameObject Facoltativo;
    void Start()
    {
        changeYPosButton.OnButtonPressed += OnChageYposButtonPressed;
    }
    private void OnChageYposButtonPressed()
    {
        var tween = transform.DOMoveY(2.3f , 5f);
        radio.SetActive(false);
        Facoltativo.SetActive(true);

    }
}
