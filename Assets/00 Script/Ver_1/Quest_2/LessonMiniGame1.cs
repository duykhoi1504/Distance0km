using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
public class LessonMiniGame1 : MonoBehaviour
{
    public List<MultipleChoiceQuestion> questions;
    [SerializeField] private TextMeshProUGUI QuestionText;
    [SerializeField] private Button[] AnswerTexts;
    private int currentQuestion;

    void OnEnable()
    {
        currentQuestion = 0;
        LoadQuestion();
    }
    void Start()
    {
        foreach (var button in AnswerTexts)
        {
            button.onClick.AddListener(() => Answer(System.Array.IndexOf(AnswerTexts, button)));
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
        }

    }
    public void NextQuestion()
    {
        currentQuestion++;
        LoadQuestion();
    }


    public void LoadQuestion()
    {
        if (currentQuestion >= questions.Count)
        {
            Complete();
            return;
        }
        if (QuestionText == null || AnswerTexts == null || AnswerTexts.Length == 0)
        {
            Debug.LogError("QuestionText hoặc AnswerTexts chưa được gán trong Inspector!");
            return;
        }
        QuestionText.text = questions[currentQuestion].question;

        for (int i = 0; i < AnswerTexts.Length; i++)
        {
            if (i < questions[currentQuestion].answers.Length)
            {
                AnswerTexts[i].GetComponentInChildren<TextMeshProUGUI>().text = questions[currentQuestion].answers[i];
                AnswerTexts[i].gameObject.SetActive(true);
            }
            else
            {
                AnswerTexts[i].gameObject.SetActive(false);
            }
        }
    }
    public void Answer(int index)
    {
        if (index ==
            questions[currentQuestion]
                .correctIndex)
        {
            Debug.Log("Đúng!");

            currentQuestion++;

            if (currentQuestion >=
                questions.Count)
            {
                Complete();
                return;
            }

            LoadQuestion();
        }
        else
        {
            Debug.Log("Sai rồi 😤");
        }
    }
    private void Complete()
    {
        Debug.Log("Quiz hoàn thành!");
        gameObject.SetActive(false);
        FindObjectOfType<LessonQuestController>().CompleteQuiz();
    }
}