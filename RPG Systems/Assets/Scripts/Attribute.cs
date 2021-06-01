using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AttributeType
{
    Health = 0,
    Mana  = 1,
    Stamina = 2
}
[CreateAssetMenu (menuName = "RPG Systems/Player/Attribute")]
public class Attribute : ScriptableObject
{
    public string attName;
    public string description;
    public int value;
    public Sprite Thumbnail;
    public AttributeType attributeType;

}
