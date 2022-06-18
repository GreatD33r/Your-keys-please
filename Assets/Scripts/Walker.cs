using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : MonoBehaviour
{
    [SerializeField] float _walkerSpeed;
    [SerializeField] public Transform[] _points;
    int _nextPointIndex;
    Transform _nextPos;

    private Rigidbody2D rb;

    private void Start()
    {
        _nextPos = _points[0];
        rb = GetComponent<Rigidbody2D>();
    }

    private void Move()
    {
        if (transform.position == _nextPos.position)
        {
            _nextPointIndex++;
            if (_nextPointIndex >= _points.Length)
            {
                _nextPointIndex = 0;
            }
            _nextPos = _points[_nextPointIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _nextPos.position, _walkerSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Move();
        }
    }

}
