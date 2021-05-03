using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;


public class LoadTest : MonoBehaviour
{
    string filePath;


    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + @"\saves\save.json";
    }

    // Update is called once per frame
    public void LoadData()
    {
        if(File.Exists(filePath))
        {
            var stringdata = File.ReadAllText(filePath);
            var data = JsonConvert.DeserializeObject<SaveFormatTest>(stringdata);
            print(data.name);
            print(data.age);
        }
    }
}
