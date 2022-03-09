using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBase : MonoBehaviour //сделать наследрвание для фруктов и бомб (хз, в одном файле, или как)
{

    private SpriteRenderer spriteRenderer;
    public List<Sprite> sprites;
    private Rigidbody2D rigidbody;
    public Transform transform;
    public int force = 30;//заменить на рандом

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D >();
        transform = this.GetComponent<Transform>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[0];//заменить на рандом
        this.Force();
    }

    private void Force()
    {
        rigidbody.AddForce(transform.up * force, ForceMode2D.Impulse);//transform.up * force заменить на рандомный угол
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
