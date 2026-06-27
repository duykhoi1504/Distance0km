
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get; private set; }
    
    public StateMachine stateMachine;
    [Header("Level Data References")]
    public LevelDataSO level1Data;
    public LevelDataSO level2Data;
    public LevelDataSO level3Data;
    private void Awake()
    {
        Instance = this;
        stateMachine = new StateMachine();
    }


    // Hàm gọi khi nhân vật tương tác với vật thể
    public void StartLevel(string levelID)
    {
        switch (levelID)
        {
            case "level_1": 
                stateMachine.Initialize(new BreakfastLevelState(this, stateMachine, level1Data)); 
                level1Data.questStateEnum = QuestStateEnum.InProgress;
                break;
            // case "level_2": 
            //     stateMachine.ChangeState(new QuizLevelState(this, stateMachine, level2Data)); 
            //     break;
            // case "level_3": 
            //     stateMachine.ChangeState(new ClickerLevelState(this, stateMachine, level3Data)); 
            //     break;
            // case "level_4": 
            //     stateMachine.ChangeState(new MemoryMapLevelState(this, stateMachine, level4Data)); 
            //     break;
        }
    }
  
    public void CompleteLevel(string levelID, LevelDataSO levelData)
    {
        
        Debug.Log($"<color=green>Hoàn thành nhiệm vụ: {levelID}</color>");
        levelData.questStateEnum = QuestStateEnum.Completed;
        // Thực hiện các hành động khi hoàn thành nhiệm vụ, ví dụ: mở khóa nhiệm vụ tiếp theo
        
        
    }
}