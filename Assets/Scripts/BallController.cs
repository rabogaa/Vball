using System;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float _speed = 0f;
    private Rigidbody _ball;
    private bool _started;
    private bool _gameover;

    void SwitchDirection()
    {
        if (_ball.velocity.x > 0)
        {
            _ball.velocity = new Vector3(0, 0, _speed);
        }
        else if (_ball.velocity.z > 0)
        {
            _ball.velocity = new Vector3(_speed, 0, 0);
        }
    }

    void Start()
    {
        _gameover = false;
        _started = false;
        _ball = GetComponent<Rigidbody>();

        if (_speed < 1)
        {
            _speed = 1;
        }
    }

    void Update()
    {
        if (!_started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                _ball.velocity = new Vector3(_speed, 0, 0);
                _started = true;
            }
        }

        _gameover = !Physics.Raycast(transform.position, Vector3.down, 100f);
        Debug.DrawRay(transform.position, Vector3.down, Color.red);

        if (!_gameover)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SwitchDirection();
            }
        }
        else
        {
            _ball.velocity = new Vector3(0, -25f, 0);
        }
    }
}