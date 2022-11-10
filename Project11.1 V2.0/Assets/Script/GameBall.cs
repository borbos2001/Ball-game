
using UnityEngine;

public class GameBall : MonoBehaviour
{
    [SerializeField] private int side;
    [SerializeField] Rigidbody ball;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "AllPeaceBall")
        switch (side)
        {
                case 1:
                ball.AddForce(Vector3.left * 3 );
                break;

                case 2:
                    ball.AddForce(Vector3.forward * 3);

                    break;
                case 3:
                    ball.AddForce(Vector3.right * 3);

                    break;
                case 4:
                    ball.AddForce(Vector3.back * 3);
                    break;
        }    
    }

}
