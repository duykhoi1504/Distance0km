using UnityEngine;

[CreateAssetMenu(fileName = "NewLevel", menuName = "GameData/Level")]
public class LevelDataSO : ScriptableObject
{   
    public QuestStateEnum questStateEnum;
    public string levelID;
    public string objectiveMessage;
    
    // Gom chung mọi loại dữ liệu ở đây (hoặc dùng Polymorphism nếu muốn phức tạp hơn)
    public string[] questions; // Cho Quiz
    public int targetEnergy;   // Cho Clicker
    public string[] mapStops;  // Cho Map
}
public enum QuestStateEnum
{
    NotStarted,
    InProgress,
    Completed
}