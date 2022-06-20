using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSorter : MonoBehaviour
{
    private SpriteRenderer sr;
    public static bool _onTrigger = false;
    public GameObject _barrier1;
    public GameObject _barrier2;
    public static bool barrierActive = false;
    

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (!barrierActive & Input.GetKeyDown(KeyCode.G) & _onTrigger)
        {
            _barrier1.SetActive(false);
            _barrier2.SetActive(true);
            barrierActive = true;
        }
        else if (barrierActive & Input.GetKeyDown(KeyCode.G) & _onTrigger)
        {
            _barrier1.SetActive(true);
            _barrier2.SetActive(false);
            barrierActive = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            sr.sortingOrder = 1;
            _onTrigger = true;

            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            sr.sortingOrder = 0;
            _onTrigger = false;
        }
        
    }
}
