using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : MonoBehaviour
{
    [SerializeField] float _walkerSpeed;
    [SerializeField] public Transform[] _points;
    int _nextPointIndex;
    Transform _nextPos;
    bool GoToPoint;
    public Animator animator;
    private Vector2 direction;

    private void Start()
    {
        animator = GetComponent<Animator>();
        _nextPos = _points[0];
    }
    private void Update()
    {

        direction = new Vector2(transform.position.x, 0);
        
        if (GoToPoint)
        {
            Move();
        }
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
            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Speed", direction.sqrMagnitude);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GoToPoint = true;
        }

        if (collision.CompareTag("Point"))
        {
            Destroy(gameObject);
        }
    }

}
