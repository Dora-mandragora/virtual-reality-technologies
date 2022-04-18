using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : ObjectBase
{
    private bool IsCutting = false;

    void Update()
    {
        if (mouseEntered)
        {            
            if (Input.GetMouseButton(0))
            {
                //Debug.Log("Ent2B");
                //animator.SetBool("isCutting", true);
                IsCutting = true;
                //StartCoroutine(DestroyObj());                
                //завершить игру
                //Destroy(this.gameObject);

            }
        }
    }

}
   
