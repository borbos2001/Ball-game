using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject death;
    private ParticleSystem ps;
    private AudioSource audio;
    void Start()
    {
        ps = death.GetComponent<ParticleSystem>();
        audio = GetComponent<AudioSource>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        {
            DeathPlayer();
        }
    }
    private IEnumerator timerDeath()
    {
        
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void DeathPlayer()
    {
        audio.Play();
        ps.Play();
        Destroy(player);
        StartCoroutine(timerDeath());
    }
}
