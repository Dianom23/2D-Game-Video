using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed = 5;
    private Rigidbody2D _rb;
    private float _moveInput;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _moveInput = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(_speed * _moveInput, _rb.velocity.y);
    }
}
