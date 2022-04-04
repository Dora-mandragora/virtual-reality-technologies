using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : ObjectBase
{
    void Update()
    {
        if (mouseEntered)
        {
            Debug.Log("EntF");
            if (Input.GetMouseButton(0))
            {
                Debug.Log("Ent2F");
                animator.SetBool("isCutting", true);
                StartCoroutine(DestroyObj());                
            }
        }
    }
}
