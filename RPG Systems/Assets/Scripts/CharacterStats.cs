using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[CreateAssetMenu(fileName = "NewCharacterStats", menuName = "RPG Systems/Stats/Create New BaseStats", order = 1)]

public class CharacterStats : MonoBehaviour
{
    /// <summary>
    /// Base Values
    /// </summary>
    public string charName;
    public int baseValue = 100;
    public int health, stamina, mana;

    public Attribute[] Attributes;
    //public List<Attribute> Attr = new List<Attribute>();
   
    public void Start()
    {
        CheckForAttributes();
        

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attributes[0].value++;
            CheckForAttributes();
        }

        
    }
    
    public void AddAttBonus(int attValue, AttributeType type, StatModType mod)
    {
        switch (type)
        {
            case AttributeType.Health:
                {
                    if (mod == StatModType.Flat)
                    {
                        health += attValue;
                    }
                    else if (mod == StatModType.PercentAdd)
                    {
                        health *= 1 + attValue / 10;
                    }
                }
                break;
            case AttributeType.Mana:
                if (mod == StatModType.Flat)
                {
                    mana += attValue;
                }
                else if (mod == StatModType.PercentAdd)
                {
                    mana *= 1 + attValue / 10;
                }
                break;

            case AttributeType.Stamina:

                if (mod == StatModType.Flat)
                {
                    stamina += attValue;
                }
                else if (mod == StatModType.PercentAdd)
                {
                    stamina *= 1 + attValue / 10;
                }
                break;

        }
    }

    public void CalulateValues()
    {

    }

    public void CheckForAttributes()
    {
        if (Attributes.Length != 0)
        {
            for (int i = 0; i < Attributes.Length; i++)
            {
                AddAttBonus(Attributes[i].value, Attributes[i].attributeType, Attributes[i].modifierType);
            }
            //if there is no specific attribute type in the array reset just that corresponding stat to its base value.
           // if(Attributes[i].attributeType != AttributeType.Health)
           // {
           //     //figure the best method for this.
           // }
        }
        else
            ResetToBaseValues();
    
      

    }

    public void ResetToBaseValues()
    {
        health = 100;
        stamina = 100;
        mana = 100;

    }
}
