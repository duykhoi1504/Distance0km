using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    private bool followPlayer = true;
    [SerializeField] private Vector3 fixedPosition;

    public float smoothSpeed = 5f;
    private void OnEnable()
    {
        IsOutRoom.OnEnterRoom += EnterRoom;
        IsOutRoom.OnExitRoom += ExitRoom;
    }

    private void OnDisable()
    {
        IsOutRoom.OnEnterRoom -= EnterRoom;
        IsOutRoom.OnExitRoom -= ExitRoom;
    }

    private void EnterRoom(Vector3 roomPos)
    {
        followPlayer = false;

        fixedPosition = new Vector3(
            roomPos.x,
            roomPos.y,
            transform.position.z
        );
    }

    private void ExitRoom()
    {
        followPlayer = true;
    }

    private void LateUpdate()
    {
        Vector3 targetPosition;

        if (followPlayer)
        {
            targetPosition = new Vector3(
                player.position.x,
                player.position.y,
                transform.position.z
            );
        }
        else
        {
            targetPosition = fixedPosition;
        }

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            smoothSpeed * Time.deltaTime
        );
    }
}
