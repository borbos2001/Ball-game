
using UnityEngine;

public class WinGame : MonoBehaviour
{
    [SerializeField] GameObject _arena;
    [SerializeField] GameObject _prize;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BallPlayer")
        {
            other.gameObject.SetActive(false);
            _arena.SetActive(false);
            _prize.SetActive(true);
        }
    }
}
