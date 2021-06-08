using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionIndicator : MonoBehaviour
{

    MouseManager mouseMan;
    // Start is called before the first frame update
    void Start()
    {
        mouseMan = GameObject.FindObjectOfType<MouseManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseMan.selectedObject != null) ;
        {
            transform.position = new Vector3(mouseMan.selectedObject.transform.position.x, 0f, mouseMan.selectedObject.transform.position.z);

        }
    }
}
