using UnityEngine;
using System.Collections;

public class SwitcHairMaterialTextures : MonoBehaviour
{
    public Material SelectedMaterial;
    public Material originalMaterial;

    public GameObject[] hairObjects;
    private int TextureIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
 
        Debug.Log("Starting experience");
    }


    public void SetSelected(){
       //gameObject.GetComponent<MeshRenderer>().material = SelectedMaterial;


        for (int i = 0; i < hairObjects.Length;  i++){
            hairObjects[i].GetComponent<MeshRenderer>().material = SelectedMaterial;
        }

    }

    public void SetUnselected(){

         for (int j = 0; j < hairObjects.Length;  j++){
            hairObjects[j].GetComponent<MeshRenderer>().material = originalMaterial;
        }
    }

}
