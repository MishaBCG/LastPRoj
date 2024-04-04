using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    public override void TakeColor()
    {
        text.text = $"Im  cylinder and my color is {color}";
    }
}
