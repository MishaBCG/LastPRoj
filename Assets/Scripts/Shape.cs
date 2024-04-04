using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected Color color;
    protected Material material;
    public TextMeshProUGUI text;
   
    
    public abstract void TakeColor();

    public void Awake()
    {
        material = GetComponent<Renderer>().material;
    }


    public virtual void RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        color = new Color(r, g, b);
        material.color = color;
    }


}
