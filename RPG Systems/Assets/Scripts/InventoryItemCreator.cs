using System.Collections;
using UnityEditor;
using UnityEngine;

public static class InventoryItemCreator {

    [MenuItem("Assets/Create/NewCharacterStats")]
    public static void CreateInventoryItem() 
    {
        CharacterStats stats = ScriptableObject.CreateInstance<CharacterStats>();
        ProjectWindowUtil.CreateAsset(stats, "NewCharacterStats.asset");
    }





}
