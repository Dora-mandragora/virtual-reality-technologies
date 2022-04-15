using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
    public Transform trail;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Debug.Log("TrailEnter");
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = -1;
            trail.position = pos;
        }
    } 


}
