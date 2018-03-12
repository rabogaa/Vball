using System;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float _speed = 0f;
    public Rigidbody ball;
    private bool _started;
    public bool gameover;

    void SwitchDirection()
    {
        if (ball.velocity.x > 0)
        {
            ball.velocity = new Vector3(0, 0, _speed);
        }
        else if (ball.velocity.z > 0)
        {
            ball.velocity = new Vector3(_speed, 0, 0);
        }
    }

    void Start()
    {
        gameover = false;
        _started = false;
        ball = GetComponent<Rigidbody>();

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
                ball.velocity = new Vector3(_speed, 0, 0);
                _started = true;
            }
        }

        gameover = !Physics.Raycast(transform.position, Vector3.down, 100f);
        Debug.DrawRay(transform.position, Vector3.down, Color.red);

        Camera.main.GetComponent<CameraController>().gameover = gameover;

        if (!gameover)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SwitchDirection();
            }
        }
        else
        {
            ball.velocity = new Vector3(0, -25f, 0);
        }
    }
}