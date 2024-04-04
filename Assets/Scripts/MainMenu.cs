using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
   private string nameEnter { get;  set; }

    public void TakeName(string n)
    {
        nameEnter = n;
        ForSaveData.instance.playerName = nameEnter;
    }
}
