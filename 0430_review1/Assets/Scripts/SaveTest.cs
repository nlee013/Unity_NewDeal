using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;


public class SaveTest : MonoBehaviour
{
    string filePath;
    string files;

    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + @"\saves";
        files = @"\save.json";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveFile()
    {
        if (!Directory.Exists(filePath))
        {
            Directory.CreateDirectory(filePath);
        }

        SaveFormatTest test = new SaveFormatTest("Love", 5);
        
        // test.sprite = information.sprite;

        //var t = JsonUtility.ToJson(test);
        var t2 = JsonConvert.SerializeObject(test);
        File.WriteAllText(filePath + files, t2);
    }

}
