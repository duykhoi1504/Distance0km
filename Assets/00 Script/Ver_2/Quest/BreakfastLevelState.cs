using UnityEngine;

public class BreakfastLevelState : BaseLevelState
{
    public BreakfastLevelState(GameManager owner, StateMachine sm, LevelDataSO data) : base(owner, sm, data) { }
    public override void Update() { /* Logic chọn đồ ăn */ }
    override public void Enter()
    {
        base.Enter(); // Tự động gọi CanMove = false từ lớp cha để giữ chân Player

        // Hiển thị UI thông báo nhiệm vụ
        Debug.Log($"<color=yellow>Nhiệm vụ: {data.objectiveMessage}</color>");
        Debug.Log("Nhấn E - Chọn Bánh mì & Salad rau củ\nNhấn R - Chọn Mì tôm trứng");

        // Bạn có thể bật UI Panel chọn món ăn ở đây nếu có giao diện Canvas
        // owner.choicePanel.SetActive(true);
    }
    private void ChooseFood(bool isCorrect)
    {
        if (isCorrect)
        {
            Debug.Log("<color=green>Giỏi thía❤️ Thưởng cho em một nụ hôn ảo! 💋</color>");

            // Nhiệm vụ hoàn thành -> Chuyển ngay sang Level 2 (Soạn giáo án)
            // stateMachine.ChangeState(new QuizState(owner, stateMachine, owner.level2Data));
            Debug.Log("<color=green>Change State (quiz)</color>");

        }
        else
        {
            // Chọn sai thì bắt chọn lại, không chuyển State
            Debug.Log("<color=red>Ớ lén hả 😤 Anh dặn phải ăn nhiều rau xanh cơ mà! Chọn lại đi cô giáo ơi!</color>");
        }
    }

    public override void Exit()
    {
        base.Exit(); // Tự động trả lại CanMove = true để Player có thể đi đến trường

        // Tắt UI Panel chọn món ăn tại đây
        // owner.choicePanel.SetActive(false);
    }
}
    
