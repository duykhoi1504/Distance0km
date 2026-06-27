using System.Collections.Generic;
using UnityEngine;

public enum QuestStatus
{
    Locked,
    Active,
    Completed
}

[System.Serializable]
public class QuestRuntime
{
    public QuestData quest;
    public QuestStatus status;
}

public class QuestManager : MonoBehaviour
{
    public static QuestManager Instance;

    [SerializeField]
    private List<QuestRuntime> quests =
        new();

    private void Awake()
    {
        if (Instance != null &&
            Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void UnlockQuest(QuestData quest)
    {
        if (quest == null)
            return;

        QuestRuntime runtime =
            GetQuest(quest);

        if (runtime == null)
        {
            runtime = new QuestRuntime
            {
                quest = quest,
                status = QuestStatus.Active
            };

            quests.Add(runtime);

            Debug.Log($"Quest Started : {quest.questName}");
            return;
        }

        if (runtime.status == QuestStatus.Completed)
            return;

        runtime.status =
            QuestStatus.Active;

        Debug.Log($"Quest Started : {quest.questName}");
    }

    public void CompleteQuest(QuestData quest)
    {
        QuestRuntime runtime = GetQuest(quest);

        if (runtime == null)
            return;

        if (runtime.status == QuestStatus.Completed)
            return;

        runtime.status = QuestStatus.Completed;

        Debug.Log($"Quest Completed : {quest.questName}");
    }

    public bool IsActive(
        QuestData quest)
    {
        QuestRuntime runtime =
            GetQuest(quest);

        return runtime != null &&
               runtime.status ==
               QuestStatus.Active;
    }

    public bool IsCompleted(
        QuestData quest)
    {
        QuestRuntime runtime =
            GetQuest(quest);

        return runtime != null &&
               runtime.status ==
               QuestStatus.Completed;
    }

    public QuestStatus GetStatus(
        QuestData quest)
    {
        QuestRuntime runtime =
            GetQuest(quest);

        return runtime == null
            ? QuestStatus.Locked
            : runtime.status;
    }

    private QuestRuntime GetQuest(QuestData quest)
    {
        return quests.Find(q => q.quest == quest);
    }

#if UNITY_EDITOR

    [ContextMenu("Print Quest List")]
    private void PrintQuestList()
    {
        foreach (var quest in quests)
        {
            Debug.Log(
                $"{quest.quest.questName} : {quest.status}");
        }
    }
    [ContextMenu("Complete All Quests")]
    private void CompleteAll()
    {
        foreach (var quest in quests)
        {
            quest.status =
                QuestStatus.Completed;
        }
    }
    [ContextMenu("Reset All Quests")]
    private void ResetAllQuests()
    {
    }

#endif
}