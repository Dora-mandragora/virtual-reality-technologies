using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int angle = Random.Range(-1, 1);
        transform.Rotate(new Vector3(0,0,rotationSpeed));
    }
}
