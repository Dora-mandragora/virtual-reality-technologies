using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    public List<GameObject> gameObjects;

    public List<SpawnerBase> spawners;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }






    // Start is called before the first frame updat
    // Update is called once per frame
    void Update()
    {
        
    }
}
