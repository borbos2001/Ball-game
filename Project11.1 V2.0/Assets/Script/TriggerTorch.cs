using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTorch : MonoBehaviour
{
    [SerializeField] GameObject Torch;
    [SerializeField] GameObject Light;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "AllPeaceBall")
        {
            Torch.SetActive(false);
            Light.SetActive(true);
        }
    }


}
