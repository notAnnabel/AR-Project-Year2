using UnityEngine;

public class DisableTheUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UIDisable()
    {
       gameObject.SetActive(false);
       Debug.Log("deactivated canvas");
    }
}
