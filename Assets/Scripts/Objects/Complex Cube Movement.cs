using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexCubeMovement : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float movementSpeed = 2f;
    public float upwardMovementRange = 2f;

    private float _startingYPosition;
    private bool _isMovingUpward = true;

    private void Start()
    {
        _startingYPosition = transform.position.y;
    }

    private void Update()
    {
        // Rotate the object around its Y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        // Move the object up and down
        MoveUpAndDown();
    }

    private void MoveUpAndDown()
    {
        Vector3 currentPosition = transform.position;

        if (_isMovingUpward)
        {
            currentPosition.y += movementSpeed * Time.deltaTime;
            if (currentPosition.y >= _startingYPosition + upwardMovementRange)
                _isMovingUpward = false;
        }
        else
        {
            currentPosition.y -= movementSpeed * Time.deltaTime;
            if (currentPosition.y <= _startingYPosition)
                _isMovingUpward = true;
        }

        transform.position = currentPosition;
    }
}
