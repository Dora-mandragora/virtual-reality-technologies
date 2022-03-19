using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBase : MonoBehaviour
{

    public ObjectBase obj;
    public Transform position;
    public float TimeSpawn;

    // Start is called before the first frame update
    void Start()
    {
        //obj.Start();
        //StartCoroutine(SpawnObj());
        //SpawnObj();
        
    }
    void Repeat()
    {
        StartCoroutine(SpawnObj());
    }
    IEnumerator SpawnObj()
    {
        //yield return new WaitForSeconds(5);                
        //Repeat();
        return null;
    }

   

}
