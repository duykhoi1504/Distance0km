using UnityEngine;


public enum LessonStage
{
    Quiz,
    Typing,
    Grading,
    Complete
}

public class LessonQuestController : MonoBehaviour
{

    // TMPro.TMP_Text QuestionText;
    // TMPro.TMP_Text[] AnswerTexts;

    [SerializeField] private QuestData GiaoAnQuest;
    private LessonStage stage;

    public void CompleteQuiz()
    {
        stage =LessonStage.Typing;
    }

    public void CompleteTyping()
    {
        stage =LessonStage.Grading;
    }

    public void CompleteGrading()
    {
        stage =LessonStage.Complete;

        QuestManager.Instance
            .CompleteQuest(
                GiaoAnQuest);
    }
}
