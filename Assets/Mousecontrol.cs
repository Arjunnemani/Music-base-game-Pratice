using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mousecontrol : MonoBehaviour
{
    public GameObject Knob;
    public int Maxpower;
    public int Minpower;

    private void Update()
    {
       
        
    }
    private void OnMouseDrag()
    {
        Vector3 currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        currentPos.z = 0;
        gameObject.transform.position = currentPos;

    }
} 
