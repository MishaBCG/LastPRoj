using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    public TextMeshProUGUI text;
    private string Name;
    


    private void Awake()
    {
        Name = ForSaveData.instance.playerName;
        
        text.text = $"Hello {Name} click on any shape to see her RGB counts";

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            takeColor();
        }
    }


    private void takeColor()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            var sp = hit.collider.GetComponent<Shape>();

            if (sp == null)
                return;

            sp.RandomColor();
            sp.TakeColor();


            if (sp is Cube cube)
                cube.DoSmth();
            

        }




    }




}
