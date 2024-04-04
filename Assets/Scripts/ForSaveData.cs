using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class ForSaveData : MonoBehaviour
{
    public static ForSaveData instance { get; private set; }

    public string playerName { get; set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }

    }


    //private void Update()
    //{
    //    if (playerName != "")
    //        Debug.Log($"HERE{playerName}");
    //}



    public void SaveGame()
    {

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/MySaveData.dat");
        SaveData data = new SaveData();

        bf.Serialize(file, data);
        file.Close();
        Debug.Log("I save");
    }

    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/MySaveData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/MySaveData.dat", FileMode.Open);
            SaveData data = (SaveData)bf.Deserialize(file);
            file.Close();

            Debug.Log("I load");
        }
        else
            Debug.Log("No Save Data");

    }


    [System.Serializable]
    class SaveData
    {


    }

}
