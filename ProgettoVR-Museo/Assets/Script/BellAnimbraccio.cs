using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BellAnimbraccio : MonoBehaviour
{

    public Button3D changeYPosButton;
    void Start()
    {
        changeYPosButton.OnButtonPressed += OnChageYposButtonPressed;
    }
    private void OnChageYposButtonPressed()
    {
        var tween = transform.DOMoveY(-0.05f , 5f);
    }
}
