using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBase : MonoBehaviour
{

    public ObjectBase obj;
    public Transform position;
    public float TimeSpawn = 1000;
    ///public event Action spawn;

   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObj());

    }
    void Repeat()
    {
        StartCoroutine(SpawnObj());
    }

    IEnumerator SpawnObj()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(obj, position.position, Quaternion.identity);
        Repeat();
    }

    

}
