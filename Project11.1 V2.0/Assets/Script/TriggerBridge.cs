using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class TriggerBridge : MonoBehaviour
    {
    [SerializeField] private GameObject _bridge;
        public void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.name == "AllPeaceBall" && NpcTrigger._wood  == true)
            {
                _bridge.SetActive(true);
            }
        }
    }


