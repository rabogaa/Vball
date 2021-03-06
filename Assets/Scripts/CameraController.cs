﻿using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool gameover { get; set; }

    [SerializeField]
    private float _lerpRate;

    [SerializeField]
    private Rigidbody _ball;

    private Vector3 offset;
    
    // Use this for initialization
    void Start()
    {
        gameover = false;
        offset = _ball.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameover)
        {
            Follow();
        }
    }

    void Follow()
    {
        transform.position = Vector3.Lerp(transform.position, _ball.transform.position - offset, _lerpRate * Time.deltaTime);
    }
}