using UnityEngine;

public enum PhoneStageEnum
{
    WakeUp,
    Breakfast,
    School,
    Park,
    Ending
}
public class Phone : Interactable
{
    public PhoneStageEnum currentStage;
     [SerializeField]private QuestData breakfastQuest;

    // public void FinishMessage()
    // {
    //     QuestManager.Instance.UnlockQuest(breakfastQuest);
    // }
    public override void Interact()
    {
        switch (currentStage)
        {
            case PhoneStageEnum.WakeUp:
                // DialogueManager.Instance.Show("Chào buổi sáng cô giáo của anh ❤️");
                Debug.Log("Chào buổi sáng cô giáo của anh ❤️");
                // QuestManager.Instance.StartQuest("Breakfast");
                currentStage = PhoneStageEnum.Breakfast;
                GameManager.Instance.StartLevel(CONSTANT.level_1);
                Debug.Log("<color=green>Start Quest: Breakfast</color>");
                // FinishMessage();
                break;

            case PhoneStageEnum.Breakfast:
                // DialogueManager.Instance.Show("Ăn rau vào nhé 😤");
                Debug.Log("Ăn rau vào nhé 😤");
                break;
        }
    }
}
