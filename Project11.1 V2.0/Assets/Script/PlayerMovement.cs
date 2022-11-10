using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {

        [SerializeField, Range(0, 20)] private float _speed = 8.0f;
        [SerializeField, Range(0, 1000)] private float _jampPower = 350.0f;
        private bool _canJamp = true;
        private Rigidbody _playerRigidBody;
        private void Start()
        {
            _playerRigidBody = GetComponent<Rigidbody>();
        }
        public void MovePlayer(Vector3 _movement)
        {
            _playerRigidBody.AddForce(_movement * _speed);
        }
        public void JampPlayer(Vector3 _jampVector)
        {
            if (Input.GetButtonDown(GlobalString._Jump_Axis) && _canJamp == true)
            {
                _playerRigidBody.AddForce(_jampVector * _jampPower);
                _canJamp = false;
                StartCoroutine(timer());

            }
        }




#if UNITY_EDITOR

        [ContextMenu("Reset values")]
            public void ResetValues()
            {
                _speed = 8;
                _jampPower = 350.0f;
            }
#endif
        private IEnumerator timer()
        {
            yield return new WaitForSeconds(3);
            _canJamp = true;
            StopCoroutine(timer());
            
        }
        

    }
}

