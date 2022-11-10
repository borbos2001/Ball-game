using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class NpcTrigger : MonoBehaviour
    {
        [SerializeField] private GameObject _npcText;
        [SerializeField] private GameObject _barrel;
        public static bool _wood = false;
        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.name == "AllPeaceBall")
            {
                _npcText.SetActive(true);
            }

        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.name == "AllPeaceBall")
            {
                _npcText.SetActive(false);
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Barrel")
            {
                _wood = true;
                _npcText = null;
                _barrel.SetActive(false);
            }

        }
    }



