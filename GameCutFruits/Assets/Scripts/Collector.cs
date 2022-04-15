using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    public List<GameObject> gameObjects;

    public List<SpawnerBase> spawners;

    public int miss = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Debug.Log("Miss fruit: " + miss);
        miss++;
    }






    // Start is called before the first frame updat
    // Update is called once per frame
    void Update()
    {
        
    }
}
