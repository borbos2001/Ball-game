using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealpTriggers : MonoBehaviour
{
    [SerializeField] private GameObject HelpTextWASD;
    private void OnTriggerStay(Collider other)
    {
        HelpTextWASD.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        HelpTextWASD.SetActive(false);
    }
}
