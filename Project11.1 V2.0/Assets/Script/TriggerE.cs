using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerE : MonoBehaviour
{
    [SerializeField] private HingeJoint _bridge;
    [SerializeField] private GameObject _helpText;
    private bool _pressed =false;
    private bool _stay = false;
    private void Update()
    {
        Open();
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "AllPeaceBall")
        {
            if (!_pressed)
            {
                _helpText.SetActive(true);
                _stay = true;
            }
            else
            {
                _helpText.SetActive(false);
                _stay = false;
            }

        }
        
    }
    private void Open()
    {
        if (Input.GetKeyDown(KeyCode.E) && _stay == true)
        {
            _bridge.useSpring = true;
            _pressed = true;

        }
    }
}
