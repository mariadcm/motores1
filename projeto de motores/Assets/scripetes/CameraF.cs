using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraF: MonoBehaviour
{
 public Transform alvo;
 public Vector3 offset;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
 
 // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - alvo.position;
    }

    // Update is called once per frame
    void Update()
    {
    transform.position = alvo.position + offset;    
    }
}
