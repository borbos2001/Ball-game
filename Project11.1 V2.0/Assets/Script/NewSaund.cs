using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSaund : MonoBehaviour
{
    [SerializeField] AudioSource _scarySound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "AllPeaceBall")
        {
            StartCoroutine(timerSound());
        }
    }
    private IEnumerator timerSound()
    {
        yield return new WaitForSeconds(2);
        _scarySound.Play();

    }
}
