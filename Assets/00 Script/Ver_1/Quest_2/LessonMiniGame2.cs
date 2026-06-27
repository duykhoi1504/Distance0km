using UnityEngine;
using TMPro;

public class LessonMiniGame2 : MonoBehaviour
{
      [SerializeField]
    private string targetWord =
        "GIAOAN";

    public TMP_InputField input;

    public void Submit()
    {
        if (input.text ==
            targetWord)
        {
            Complete();
        }
        else
        {
            input.text = "";

            Debug.Log(
                "Sai rồi 😤");
        }
    }

    private void Complete()
    {
        Debug.Log(
            "Hoàn thành Giáo án 2");
    }
}
