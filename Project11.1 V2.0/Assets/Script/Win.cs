using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private ParticleSystem first;
    [SerializeField] private ParticleSystem second;
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        {
            if (SceneManager.GetActiveScene().buildIndex != 5)
            {
                audio.Play();
                first.Play();
                second.Play();
                StartCoroutine(timerWin());
                Destroy(player);


            }
            else
            {
                audio.Play();
                first.Play();
                second.Play();
                StartCoroutine(timerLastWin());
                Destroy(player);
            }
        }
    }
    private IEnumerator timerWin()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private IEnumerator timerLastWin()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
