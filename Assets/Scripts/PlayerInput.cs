using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public enum RotationDir
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }
    
     public float _sensitivity;
     private Vector3 _mouseReference;
     private Vector3 _mouseOffset;
     private bool _isRotating;
   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // rotating flag
            _isRotating = true;

            // store mouse
            _mouseReference = Input.mousePosition;
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            _isRotating = false;

        }

        if (_isRotating)
        {
            // offset
            _mouseOffset = (Input.mousePosition - _mouseReference);

            // apply rotation
            Vector3 _rotation = Vector3.zero;
            //_rotation.y = -(_mouseOffset.x + _mouseOffset.y) * _sensitivity;

            _rotation.y = -(_mouseOffset.x) * _sensitivity;
            _rotation.x = _mouseOffset.y * _sensitivity;

            // rotate
            transform.Rotate(_rotation);
            GameplayController.Instance.AddObjectRotation(_rotation);
            
            // store mouse
            _mouseReference = Input.mousePosition;
        }


        //LEGACY? -> ???
        // if (Input.GetKeyDown(KeyCode.LeftArrow))
        // {
        //     GameplayController.Instance.AddObjectRotation(RotationDir.LEFT);
        // }
        // else if (Input.GetKeyDown(KeyCode.RightArrow))
        // {
        //     GameplayController.Instance.AddObjectRotation(RotationDir.RIGHT);
        // }
        // else if (Input.GetKeyDown(KeyCode.UpArrow))
        // {
        //     GameplayController.Instance.AddObjectRotation(RotationDir.UP);
        // }
        // else if (Input.GetKeyDown(KeyCode.DownArrow))
        // {
        //     GameplayController.Instance.AddObjectRotation(RotationDir.DOWN);
        // }

    }

    void OnMouseDown()
    {
        // rotating flag
        _isRotating = true;
        
        // store mouse
        _mouseReference = Input.mousePosition;
    }
     
    void OnMouseUp()
    {
        // rotating flag
        _isRotating = false;
    }
}
