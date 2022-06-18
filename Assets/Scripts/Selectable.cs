using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var sr = GetComponent<Renderer>();
            sr.material.color = new Color(1f, 1f, 1f, 0.4f);
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        var sr = GetComponent<Renderer>();
        sr.material.color = new Color(1f, 1f, 1f, 1f);
    }



    /*
    public void Select()
    {
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 100);
         var sr = GetComponent<SpriteRenderer>();
         sr.color = new Color(0, 0, 0, 0.5f);
    }

    public void Deselect()
    {
        GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0f);
    }*/
}
