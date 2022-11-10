using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWorld : MonoBehaviour
{
    private bool world = true;
    [SerializeField] private GameObject _worldLeft;
    [SerializeField] private GameObject _worldRight;
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject _playerSkin1;
    [SerializeField] private GameObject _playerSkin2;
    [SerializeField] private GameObject _ball;
    [SerializeField] private AudioSource _audioSource1;
    private void Start()
    {
        _camera.backgroundColor = Color.Lerp(Color.white, Color.blue, 0.7f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "AllPeaceBall")
        {
            if (world)
            {
                _worldRight.SetActive(false);
                _worldLeft.SetActive(true);
                _camera.backgroundColor = Color.Lerp(Color.Lerp(Color.black, Color.blue, 0.2f),Color.red, 0.2f) ;
                world = false;
                _playerSkin2.SetActive(true);
                _playerSkin1.SetActive(false);
                _ball.SetActive(false);
                _audioSource1.Play();
            }
            else
            {
                _worldLeft.SetActive(false);
                _worldRight.SetActive(true) ;
                _camera.backgroundColor = Color.Lerp(Color.white, Color.blue, 0.7f) ;
                world = true;
                _playerSkin2.SetActive(false);
                _playerSkin1.SetActive(true);
                _audioSource1.Play();
            }

        }
    }
}
