using System.Collections;
using UnityEditor;
using UnityEngine;

public static class AbilityCreator {

    [MenuItem("Assets/Create/Create New Ability")]
    public static void CreateNewAbility() 
    {
        CharacterStats stats = ScriptableObject.CreateInstance<CharacterStats>();
        ProjectWindowUtil.CreateAsset(stats, "NewAbility.asset");
    }

}
