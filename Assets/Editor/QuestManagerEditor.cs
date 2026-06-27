// using UnityEditor;
// using UnityEngine;

// [CustomEditor(typeof(QuestManager))]
// public class QuestManagerEditor : Editor
// {
//     public override void OnInspectorGUI()
//     {
//         DrawDefaultInspector();

//         QuestManager manager =
//             (QuestManager)target;

//         if (GUILayout.Button("Print Quest List"))
//         {
//             // manager.PrintQuestList();
//             Debug.Log("Print Quest List");
//         }

//         if (GUILayout.Button("Complete All Quests"))
//         {
//             // manager.CompleteAll();
//             Debug.Log("Complete All Quests");
//         }

//         if (GUILayout.Button("Reset All Quests"))
//         {
//             // manager.ResetAllQuests();
//             Debug.Log("Reset All Quests");
//         }
//     }
// }