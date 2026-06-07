using System;
using UnityEngine;

public class IsOutRoom : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static event Action<Vector3> OnEnterRoom;
    public static event Action OnExitRoom;

    [SerializeField]
    private Transform roomCameraPosition;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        Debug.Log("Player entered room");

        OnEnterRoom?.Invoke(
            roomCameraPosition.position
        );
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        Debug.Log("Player exited room");

        OnExitRoom?.Invoke();
    }

}
