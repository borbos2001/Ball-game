using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class NpcTrigger1 : MonoBehaviour
    {
        [SerializeField] private GameObject _npcTextLvL4;

    private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.name == "AllPeaceBall")
            {
            _npcTextLvL4.SetActive(true);
            }

        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.name == "AllPeaceBall")
            {
            _npcTextLvL4.SetActive(false);
            }
        }
    }



