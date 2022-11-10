
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    private Vector3 offset;


    private void Start()
    {
        offset = transform.position -_playerTransform.position;
    }
    private void FixedUpdate()
    {
        transform.position = offset + _playerTransform.position;
    }
}
