using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIAttributePanel : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text valueText;


    // Start is called before the first frame update
    private void OnValidate()
    {
        TMP_Text[] texts = GetComponentsInChildren<TMP_Text>();
        nameText = texts[0];
        valueText = texts[1];

    }

   
}
