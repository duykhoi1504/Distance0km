using UnityEngine;

public class Door : MonoBehaviour
{
   public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the door trigger.");
            // You can add code here to handle what happens when the player enters the door trigger
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)            {
                spriteRenderer.color = Color.red; // Change the door color to red when the player enters
            }
        }

    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited the door trigger.");
            // You can add code here to handle what happens when the player exits the door trigger
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)            {
                spriteRenderer.color = Color.white; // Change the door color back to white when the player exits
            }
        }
    }
}
