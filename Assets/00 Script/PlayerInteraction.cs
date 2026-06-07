using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Interactable currentInteractable;

    private void Update()
    {
        if (currentInteractable == null)
            return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            currentInteractable.Interact();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Interactable interactable =other.GetComponent<Interactable>();
        if (interactable == null)
            interactable =other.GetComponentInParent<Interactable>();
        if (interactable != null)
        {
            currentInteractable = interactable;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Interactable interactable =other.GetComponent<Interactable>();
        if (interactable == null)
            interactable =other.GetComponentInParent<Interactable>();

        if (interactable == currentInteractable)
        {
            currentInteractable = null;
        }
    }
}
