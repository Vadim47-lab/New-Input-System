﻿using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = new PlayerInput();

        _playerInput.Player.Shoot.performed += ctx => OnShoot();
        _playerInput.Player.Shoot.performed += ctx => OnMove();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    public void OnShoot()
    {
        Debug.Log("Class PlayerShooter - Shoot!");
    }

    public void OnMove()
    {
        Vector2 moveDirection = _playerInput.Player.Move.ReadValue<Vector2>();
        Debug.Log(moveDirection);
    }
}