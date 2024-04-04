using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cube : Shape
{







    public override void TakeColor()
    {
        text.text = $"Im cube and my color is {color}";
    }

    public void DoSmth()
    {
        Debug.Log("I cube");
    }

}
