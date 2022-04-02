using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBase : MonoBehaviour //������� ������������ ��� ������� � ���� (��, � ����� �����, ��� ���)
{
    private SpriteRenderer spriteRenderer;
    public List<Sprite> sprites;
    public Transform position;
    private Rigidbody2D rigidbody;

    public Animator animator;

    private bool mouseEntered;

    public int force;

    // Start is called before the first frame update

    public void Start()
    {        
        spriteRenderer = GetComponent<SpriteRenderer>();
        position = GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody2D>();
        var spriteNum = 0;
        if (sprites.Count != 0)
        {
            spriteNum = Random.Range(0, sprites.Count - 1);
            spriteRenderer.sprite = sprites[spriteNum];
        }

        Force();
    }
    

    // Update is called once per frame
    void Update()
    {
        if(mouseEntered)
        {
            Debug.Log("Ent");
            if (Input.GetMouseButton(0))
            {
                Debug.Log("Ent2");
                animator.SetBool("isCutting", true);
                StartCoroutine(DestroyObj());
                //Destroy(this.gameObject);
            }
        }
    }
    private void Force()
    {
        force = Random.Range(15, 20);
        var vector = new Vector2(Random.Range(-0.25f, 0.25f), 1);
        rigidbody.AddForce(vector * force, ForceMode2D.Impulse);
    }

    private void OnMouseEnter()
    {
        mouseEntered = true;
    }

    private void OnMouseExit()
    {
        mouseEntered = false;
    }


    /* private void OnMouseDrag()
     {
         Destroy(this.gameObject);
     }
 */

    //abstract public void dest();

    private void OnMouseDown()
    {
        
       // Destroy(this.gameObject);
    }

    IEnumerator DestroyObj()
    {        
        yield return new WaitForSeconds(10);
        Destroy(this.gameObject);
    }





}


public class Fruit : ObjectBase
{


    public void OnDestroy()
    {
        
    }
}