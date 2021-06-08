using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatDisplay : MonoBehaviour
{
    public UIAttributePanel[] attributePanels;
    public Attribute[] attributes; 
  
    // Start is called before the first frame update
    void Start()
    {
        attributes = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterStats>().Attributes;
        attributePanels = GetComponentsInChildren<UIAttributePanel>();
        for (int i = 0; i < attributes.Length; i++)
        {
            attributePanels[i].gameObject.SetActive(i < attributes.Length);
        }

        UpdateAttributeValues();
        Debug.Log(attributes.Length);
    }

    

    // Update is called once per frame
    public void UpdateAttributeValues()
    {
        for (int i = 0; i < attributes.Length; i++)
        {
            attributePanels[i].valueText.text = attributes[i].value.ToString();
            attributePanels[i].nameText.text = attributes[i].name.ToString();

        }
    }
}
