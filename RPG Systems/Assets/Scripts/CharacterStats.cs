using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewCharacterStats", menuName = "RPG Systems/Stats/Create New BaseStats", order = 1)]

public class CharacterStats : ScriptableObject {

    public string charName;
    public float health;
    public int stamina, mana, defense, resistance;
    public int strength, dexterity, constitution, intellect, luck;

    private float currentExperience;



}
 