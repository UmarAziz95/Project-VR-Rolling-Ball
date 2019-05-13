using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform ball;
    public Transform cameraFloorOffset;
    public Vector3 cameraOffSet;

    void Update()
    {
        cameraFloorOffset.position = ball.position + cameraOffSet;
    }
}
