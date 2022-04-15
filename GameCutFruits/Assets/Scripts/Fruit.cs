using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : ObjectBase
{
    
    //переделать эту модель - повесить ее на manager?
    void Update()
    {
        if (mouseEntered)
        {            
            if (Input.GetMouseButton(0))
            {
                Debug.Log("Ent2F");
                //animator.SetBool("isCutting", true);

                //StartCoroutine(DestroyObj());               
                //DestroyObj();                
                //Destroy(this.gameObject);
            }
        }

       
    }

    public new bool IsFruit() => true;
}
