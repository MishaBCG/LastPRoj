using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public string nameEnter { get;  private set; }

    public void TakeName(string n)
    {
        nameEnter = n;
        ForSaveData.instance.playerName = nameEnter;
    }

    public void Game()
    {
        SceneManager.LoadScene(1);
    }
}
