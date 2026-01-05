using UnityEngine;
using UnityEngine.UI;

public class ChangeActive : MonoBehaviour
{

    public GameObject[] objectsToToggle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(objectsToToggle[0].name))
        {
            foreach (GameObject obj in objectsToToggle)
            {
                obj.SetActive(!obj.activeSelf);
            }
        }
        
    }
}
