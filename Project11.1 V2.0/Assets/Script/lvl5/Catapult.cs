using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] private GameObject _catapultaObject;
    [SerializeField] private GameObject _helpTextLvL5;
    private float _targetPosition;
    private bool _stayLvL5 = false;
    private HingeJoint _hinge;
    private JointSpring _hingeSpring;
    void Start()
    {
        _hinge = _catapultaObject.gameObject.GetComponent<HingeJoint>();
        _hingeSpring = _hinge.spring;
    }
    private void Update()
    {
        Open();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "AllPeaceBall")
        {
            _stayLvL5 = true;
            _helpTextLvL5.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "AllPeaceBall")
        {
            _stayLvL5 = false;
            _helpTextLvL5.SetActive(false);
        }

    }
    private void Open()
    {
        if (Input.GetKeyDown(KeyCode.E) && _stayLvL5 == true)
        {
            _hingeSpring.targetPosition = -100f;
            _hinge.spring = _hingeSpring;
        }
    }

}
