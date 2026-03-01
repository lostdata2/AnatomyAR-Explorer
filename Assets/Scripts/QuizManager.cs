using UnityEngine;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gradeText;
    public TextMeshProUGUI messageText;

    public void AddScore() 
    {
        score++;
    }

    public void ShowResults(int totalQuestions)
    {
        float percentage = (float)score / totalQuestions * 100f;

        scoreText.text = $"Правильных ответов: {score} из {totalQuestions}";
        
        if (percentage >= 90) {
            SetResult("5+", "Потрясающе! Ты настоящий знаток анатомии!");
        } else if (percentage >= 75) {
            SetResult("5", "Отличный результат! Почти без ошибок.");
        } else if (percentage >= 50) {
            SetResult("4", "Хорошая работа! Ты неплохо разбираешься в теме.");
        } else if (percentage >= 30) {
            SetResult("3", "Нормально, но стоит еще разок заглянуть в учебник.");
        } else {
            SetResult("2", "Не переживай, это был сложный тест. Попробуй еще раз!");
        }
    }

    private void SetResult(string grade, string message)
    {
        gradeText.text = $"Оценка: {grade}";
        messageText.text = message;
    }
}