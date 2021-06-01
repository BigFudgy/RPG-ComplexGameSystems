using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class StatModifier
{
    [SerializeField] private float value = 0f;
    [SerializeField] private StatModType type = StatModType.None;

    public float Value { get { return value; } }
    public StatModType Type { get { return type; } }

    public StatModifier(float value, StatModType type)
    {
        this.value = value;
        this.type = type;
    }
}
public enum StatModType
{
    None = -1,
    Flat = 0,
    PercentAdd = 1,
    
}
