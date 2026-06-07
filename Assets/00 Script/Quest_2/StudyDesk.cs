using UnityEngine;

public class StudyDesk : MonoBehaviour
{
    [SerializeField] private QuestData lessonQuest;

    [SerializeField] private GameObject lessonCanvas;

    private bool playerInRange;

    private void Update()
    {
        if (!playerInRange)
            return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            OpenLesson();
        }
    }

    private void OpenLesson()
    {
        if (!QuestManager.Instance.IsActive(lessonQuest))
            return;

        lessonCanvas.SetActive(true);
        Debug.Log("Bắt đầu soạn giáo án");
        Player_Movement.Instance.CanMove = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        playerInRange = true;

        Debug.Log("Nhấn E để ngồi vào bàn học");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;
        playerInRange = false;
    }
}
