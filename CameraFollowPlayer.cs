using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform Screen;
    public Vector3 offset;
    void Update()
    {
        transform.position = Screen.position + offset;
    }
}
