using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "QuestDatabase",
    menuName = "Game/Quest Database")]
public class QuestDatabase : ScriptableObject
{
    public List<QuestData> quests;
}