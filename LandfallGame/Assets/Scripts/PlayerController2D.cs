using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    //editable fields
    [SerializeField]
    float
        _playerWalkSpeed = 5.5f;

    //private fields
    Vector2 _playerMoveDir;
    Rigidbody2D _rb;

    private void Awake()
    {
        //assigning RB to field 
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //player movement variables
        float _moveX = 0f;
        float _moveY = 0f;

        //Player Movment inputs
        if (Input.GetKey(KeyCode.W))
        {
            _moveY = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _moveY = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _moveX = 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _moveX = -1f;
        }

        //assign move direction to new vector
        _playerMoveDir = new Vector2(_moveX, _moveY).normalized;
    }

    private void FixedUpdate()
    {      
        //move player object
        _rb.velocity = _playerMoveDir * _playerWalkSpeed;    
    }
}
