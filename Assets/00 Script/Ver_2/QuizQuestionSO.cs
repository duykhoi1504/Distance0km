using UnityEngine;

// Dòng này giúp bạn có thể click chuột phải trong Unity -> Create -> Game Data -> Quiz Question
[CreateAssetMenu(fileName = "NewQuestion", menuName = "Game Data/Quiz Question")]
public class QuizQuestionSO : ScriptableObject
{
    [TextArea]
    public string questionText;
    public string[] options;
    public int correctIndex;
}