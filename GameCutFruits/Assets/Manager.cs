using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int globalScore;
    private int bestScore;
    private Vector3 lastMousePos;
    private bool isGameEnd;

    public Collider2D[] gameObjects;

    public GameObject end;
    public GameObject trail;

    public GameObject FruitPrefab;
    public GameObject BombPrefab;

    public GameObject EndGameUI;

    public Font font;

    GUIStyle style = new GUIStyle();
        
    void Start()
    {
        EndGameUI.SetActive(false);
        isGameEnd = false;

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
        if (end.GetComponent<Collector>().miss >= 3)
            EndGame();
        if (Input.GetMouseButton(0) && Time.timeScale != 0 && !isGameEnd)
        {
            //проверять мин скорость            
            var thisFrameFruits = Physics2D.OverlapBoxAll(new Vector2(trail.transform.position.x, trail.transform.position.y), new Vector2(1, 1), 0);
            if ((Input.mousePosition - lastMousePos).sqrMagnitude > 9f)
                foreach (var obj in thisFrameFruits)
                {
                    var obj2 = obj.GetComponent<ObjectBase>();
                    if (obj2 is Fruit)
                    {                       
                        obj.GetComponent<ObjectBase>().Destroy();
                        globalScore += 10;
                    }
                    else
                    {
                        EndGame();
                        obj.GetComponent<ObjectBase>().Destroy();
                        //globalScore -= 10;
                    }
                }
            lastMousePos = Input.mousePosition;
            //
        }

    }

    void EndGame()
    {        
        StopAllCoroutines();
        isGameEnd = true;
        EndGameUI.SetActive(true);
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
