// public class QuizState : BaseState<GameManager>
// {
//     public QuizState(GameManager owner, StateMachine sm) : base(owner, sm) {}

//     public override void Enter()
//     {
//         // Hiển thị giao diện dựa trên owner.quizLevelData
//         Debug.Log("Đang tải: " + owner.quizLevelData.levelName);
//     }

//     public override void Update()
//     {
//         // Kiểm tra logic nhấn phím hoặc chạm màn hình tại đây
//     }

//     public void CheckAnswer(int index)
//     {
//         if(index == owner.quizLevelData.correctIndex) 
//         {
//             Debug.Log("Đúng rồi!");
//             // Chuyển sang state tiếp theo
//         }
//     }
// }