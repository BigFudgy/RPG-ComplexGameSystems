using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    public float health;
    public int stamina, mana, defense, resistance;
    public int strength, dexterity, constitution, intellect, luck;



    [System.Serializable]
    public class CombatStats
    {
        public float attackPower;
        public float defense;
        public float dodge;
    }
}
