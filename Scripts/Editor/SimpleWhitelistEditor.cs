using UnityEditor;
using UdonSharpEditor;
using UnityEditorInternal;
using UnityEngine;

[CustomEditor(typeof(SimpleWhitelist))]
public class SimpleWhitelistEditor : Editor
{
    GUIStyle titleStyle;
    SerializedProperty whitelistProperty;

    ReorderableList whitelistList;

    private void OnEnable() 
    {
        titleStyle = new GUIStyle();
        titleStyle.fontSize = 36;
        titleStyle.alignment = TextAnchor.MiddleCenter;
        titleStyle.fontStyle = FontStyle.Bold;

        whitelistProperty = serializedObject.FindProperty(nameof(SimpleWhitelist.whitelist));

        whitelistList = new ReorderableList(serializedObject, whitelistProperty, true, true, true, true);
        whitelistList.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) =>
        {
            EditorGUI.PropertyField(
                new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), 
                whitelistList.serializedProperty.GetArrayElementAtIndex(index), 
                label: new GUIContent()
                );
        };
        whitelistList.drawHeaderCallback = (Rect rect) => 
        { 
            EditorGUI.LabelField(rect, new GUIContent("Whitelisted Players", "The VRChat usernames of the players to be whitelisted")); 
        };
    }

    public override void OnInspectorGUI()
    {
        if (UdonSharpGUI.DrawDefaultUdonSharpBehaviourHeader(target)) return;

        // EditorGUILayout.Space(25f);
        // EditorGUILayout.LabelField("Simple Whitelist", titleStyle);

        serializedObject.Update();

        EditorGUILayout.Space(15f);
        whitelistList.DoLayoutList();
        EditorGUILayout.Space(5f);

        serializedObject.ApplyModifiedProperties();
    }
}
