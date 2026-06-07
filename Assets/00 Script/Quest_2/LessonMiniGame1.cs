using UnityEngine;
using System.Collections.Generic;

public class LessonMiniGame1 : MonoBehaviour
{
    public List<MultipleChoiceQuestion> questions;

    private int currentQuestion;

    public void Answer(int index)
    {
        if (index == questions[currentQuestion].correctIndex)
        {
            currentQuestion++;

            if (currentQuestion >= questions.Count)
            {
                Complete();
            }
        }
    }

    private void Complete()
    {
        Debug.Log("Hoàn thành Giáo án 1");
    }
}