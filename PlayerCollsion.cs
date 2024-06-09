using UnityEngine;

public class PlayerCollsion : MonoBehaviour
{
    public PlayerMovement Move;
    public void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            Move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
