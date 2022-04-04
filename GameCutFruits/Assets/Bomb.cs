using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : ObjectBase
{    
    void Update()
    {
        if (mouseEntered)
        {
            Debug.Log("EntB");
            if (Input.GetMouseButton(0))
            {
                Debug.Log("Ent2B");
                animator.SetBool("isCutting", true);
                StartCoroutine(DestroyObj());
                //Destroy(this.gameObject);
            }
        }
    }
}
   
