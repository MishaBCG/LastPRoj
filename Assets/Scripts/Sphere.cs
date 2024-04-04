using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Sphere : Shape
{
    public override void TakeColor()
    {
        text.text = $"Im Sphere and my color is {color}";
    }
}
