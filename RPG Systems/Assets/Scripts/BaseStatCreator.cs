using System.Collections;
using UnityEditor;
using UnityEngine;

public class BaseStatCreator  
{

    public static void CreateNewBaseStats() 
    {
        CharacterStats stats = ScriptableObject.CreateInstance<CharacterStats>();
        ProjectWindowUtil.CreateAsset(stats, "BaseStats.asset");
    }

}
