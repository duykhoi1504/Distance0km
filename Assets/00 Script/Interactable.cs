using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string interactionText = "Nhấn E";

    public abstract void Interact();
}