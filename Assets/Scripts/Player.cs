using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    private Rigidbody2D _rb;
    [SerializeField] private float _moveInput;
    private SpriteRenderer _sr;
    [SerializeField] private float _jumpForce = 5;
    [SerializeField] private bool _isGrounded;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _moveInput = Input.GetAxisRaw("Horizontal");

        if (_moveInput != 0 && _isGrounded)
        {
            _animator.SetBool("Move", true);
        }
        else
        {
            _animator.SetBool("Move", false);
        }

        _rb.velocity = new Vector2(_speed * _moveInput, _rb.velocity.y);
        if (_rb.velocity.x > 0)
        {
            _sr.flipX = true;
        }
        else if (_rb.velocity.x < 0)
        {
            _sr.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            _isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            _isGrounded = false;
        }
    }
}
