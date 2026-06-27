using UnityEngine;
using TMPro;
public class LessonMiniGame3 : MonoBehaviour
{
    public TMP_InputField scoreInput;

    public void Grade()
    {
        if (!int.TryParse(
                scoreInput.text,
                out int score))
            return;

        if (score < 5)
        {
            Debug.Log(
                "Ở thấp điểm vậy 😒");
        }
        else if (score < 10)
        {
            Debug.Log(
                "Chỉ vậy thui hả 😑");
        }
        else
        {
            Debug.Log(
                "Hoàn hảo ❤️");

            Complete();
        }
    }

    private void Complete()
    {
        Debug.Log(
            "Hoàn thành Giáo án 3");
    }
}
