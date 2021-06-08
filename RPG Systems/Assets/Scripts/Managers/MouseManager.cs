using UnityEngine.EventSystems;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public GameObject selectedObject;
    public LayerMask selectableMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, selectableMask))
            {

                Debug.Log("Selected Object");
                GameObject hitObject = hit.transform.root.gameObject;

                SelectedObject(hitObject);
            }
        }
    }

    void SelectedObject(GameObject obj)
    {
        if (selectedObject != null)
        {
            if(obj == selectedObject)
                return;
            
            ClearSelectedObj();
        }

        selectedObject = obj;

    }

    void ClearSelectedObj()
    {
        selectedObject = null;
    }
}
