using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBase : MonoBehaviour //������� ������������ ��� ������� � ���� (��, � ����� �����, ��� ���)
{
    private SpriteRenderer spriteRenderer;
    public List<Sprite> sprites;
    public Transform position;
    private Rigidbody2D rigidbody;

    public int force;

    // Start is called before the first frame update

    public void Start()
    {        
        spriteRenderer = GetComponent<SpriteRenderer>();
        position = GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody2D>();
        var spriteNum = Random.Range(0, sprites.Count - 1);
        spriteRenderer.sprite = sprites[spriteNum];

        Force();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Force()
    {
        force = Random.Range(15, 20);
        rigidbody.AddForce(position.up * force, ForceMode2D.Impulse);
    }
}
