using UnityEngine;

[CreateAssetMenu(
    fileName = "Quest",
    menuName = "Game/Quest"
)]
public class QuestData : ScriptableObject
{
    public int id;

    public string questName;

    [TextArea]
    public string description;
}