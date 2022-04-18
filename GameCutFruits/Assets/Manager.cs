using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int globalScore;
    private int bestScore;
    private int combo = 0;

    public Collider2D[] gameObjects;

    public GameObject end;
    public GameObject trail;

    public GameObject FruitPrefab;
    public GameObject BombPrefab;

    public Font font;

    GUIStyle style = new GUIStyle();
        
    void Start()
    {
        style.normal.textColor = Color.yellow;        
        style.fontSize = 40;
        style.font = font;

        globalScore = 0;

        StartCoroutine(SpawnFruits(6, 5));
        StartCoroutine(SpawnBomb());

    }
    void RepeatFruits()
    {
        StartCoroutine(SpawnFruits(6, 5));        
    }

    void RepeatBomb()
    {
        StartCoroutine(SpawnBomb());
    }

    IEnumerator SpawnFruits(float xStart, float deltaTime)
    {
        float sec = Random.Range(0, deltaTime);
        yield return new WaitForSeconds(sec);
        Instantiate(FruitPrefab, new Vector3(xStart, -12,0), Quaternion.identity);
        sec = Random.Range(0, deltaTime);
        yield return new WaitForSeconds(sec);
        Instantiate(FruitPrefab, new Vector3(xStart-12, -12, 0), Quaternion.identity);
        RepeatFruits();
    }

    IEnumerator SpawnBomb()
    {
        float sec = Random.Range(0, 10);
        float xStart = Random.Range(-12, 12);
        yield return new WaitForSeconds(sec);
        Instantiate(BombPrefab, new Vector3(xStart, -12, 0), Quaternion.identity);
        RepeatBomb();
    }    

    void Update()
    {
        //проверять мин скорость
        var mousePos = Input.mousePosition;
        //var thisFrameFruits = Physics2D.OverlapPointAll(new Vector2(trail.transform.position.x, trail.transform.position.y), LayerMask.GetMask("Fruits"));
        var thisFrameFruits = Physics2D.OverlapBoxAll(new Vector2(trail.transform.position.x, trail.transform.position.y), new Vector2(1,1),0);
        //Debug.Log(thisFrameFruits.Length);
        foreach(var obj in thisFrameFruits)
        {
            var obj2 = obj.GetComponent<ObjectBase>();
            //не работает корректно, потому что проверку через дочерний класс не организовать - если это будет бомба, то происходит ошибка
            //if (obj.GetComponent<Fruit>().IsFruit())
            if(obj2 is Fruit)
            {
                obj.GetComponent<ObjectBase>().Destroy();
                globalScore += 10;
            }
            //if (!obj.GetComponent<Bomb>().IsFruit())
            else
            {
                obj.GetComponent<ObjectBase>().Destroy();
                globalScore -= 10;
            }
        }
        //if (end.GetComponent<Collector>().miss >= 3) Debug.Log("YOU LOSE!!!");
        
    }


    private void OnGUI()
    {
        GUILayout.Label("" + (int)globalScore, style);       
    }  
    
}






// Функция UPDATE - неверно работает

//var thisFrameFruits = Physics2D.OverlapPointAll(new Vector2(trail.transform.position.x, trail.transform.position.y), LayerMask.GetMask("Fruits"));


//foreach (var c2 in thisFrameFruits)
//{
//    for (int i = 0; i < gameObjects.Length; i++)
//    {
//        Debug.Log("Obj");
//        if (c2 == gameObjects[i])
//        {

//            //c2.GetComponent<ObjectBase>().DestroyObjValue(this);                    
//        }
//    }
//}
//gameObjects = thisFrameFruits;
