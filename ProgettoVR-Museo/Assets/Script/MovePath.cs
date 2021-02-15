using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
 

public class MovePath : MonoBehaviour

{

  
    [SerializeField] private Transform _waypointRoot;
    [SerializeField] private float _pathDuration;

    // Start is called before the first frame update
    void Start()
    {
        if(_waypointRoot != null && _waypointRoot.childCount > 0)
        {
            Vector3[] pathPosition = new Vector3[_waypointRoot.childCount];
            for (int i = 0; i < _waypointRoot.childCount; i++)
                pathPosition[i] = _waypointRoot.GetChild(i).position;

            //var tween = transform.DOPath(pathPosition, _pathDuration, PathType.Linear, PathMode.Full3D,
            //    resolution: 10, Color.yellow).SetLoops(-1, LoopType.Yoyo);
            GetComponent<Rigidbody>().DOPath(pathPosition, _pathDuration, PathType.Linear, PathMode.Full3D,
               resolution: 10, Color.yellow).SetLoops(-1, LoopType.Yoyo);



        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // transform.DOPause();
        GetComponent<Rigidbody>().DOPause();
       
    }
    private void OnTriggerExit(Collider other)
    {
        // transform.DOPlay();
        GetComponent<Rigidbody>().DOPlay();
    }
}
