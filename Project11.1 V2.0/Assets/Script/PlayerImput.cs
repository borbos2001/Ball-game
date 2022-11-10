using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent (typeof(PlayerMovement))]
    public class PlayerImput : MonoBehaviour

    {

        private Vector3 _movement;
        private Vector3 _jampVector;
        private PlayerMovement _playerMovement;

        private void Awake()
        {
            _playerMovement = GetComponent<PlayerMovement>();
        }

        private void Update()
        {
            float _harizontal = Input.GetAxis(GlobalString._Horizontal_Axis);
            float _vertical = Input.GetAxis(GlobalString._Verticall_Axis);
            _movement = new Vector3(_harizontal, 0, _vertical).normalized;
            _jampVector = new Vector3(0, 1, 0).normalized;
            _playerMovement.JampPlayer(_jampVector);

        }
        private void FixedUpdate()
        {
            _playerMovement.MovePlayer(_movement);
        }
    }

}

