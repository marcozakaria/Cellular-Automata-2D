using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellUpdater : MonoBehaviour
{
    public Color enteredColor;

    private SpriteRenderer spriteRenderer;
    private bool empty = true;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ant"))
        {           
            ChangeColor();
        }
    }

    void ChangeColor()
    {
        if (empty)
        {
            spriteRenderer.color = enteredColor;
            gameObject.tag = "right";
        }
        else
        {
            spriteRenderer.color = Color.white;
            gameObject.tag = "left";
        }
        empty = !empty;
    }
}
