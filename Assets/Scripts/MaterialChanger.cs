using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    private Material material;

    bool toggleColor = false;


    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        material = meshRenderer.material;

    }

    public void ChangeColor()
    {
        if(toggleColor == false){
            material.color = Color.red;
            toggleColor = true;
        }  
        else{
            material.color = Color.green;
            toggleColor = !true;
        }
    }

    public void SetRandomColor(){
        Color randomColor = Random.ColorHSV(0f, 1f, 1f,1f,0.5f,1f);
        material.color = randomColor;
        material.SetColor(material.name, randomColor);
    }
}
