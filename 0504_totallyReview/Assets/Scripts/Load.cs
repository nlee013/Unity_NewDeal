using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    [SerializeField] Text Nameinfo, ageinfo, phoneNumber, fileInfo;

    string filepath;

    [SerializeField] LoadImage load;

    // Start is called before the first frame update
    void Start()
    {
        filepath = Application.persistentDataPath + @"SaveFile" + @"\L" + fileInfo.text + "LINA.json";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadData()
    {
        if (File.Exists(filepath))
        {
            var data = File.ReadAllText(filepath);
            var dataObject = JsonConvert.DeserializeObject<FileDataFormat>(data);

            Nameinfo.text = dataObject.Name;
            ageinfo.text = dataObject.age.ToString();
            phoneNumber.text = dataObject.phoneNumber.ToString();
            load.width = dataObject.width;
            load.height = dataObject.height;

        }
    }
}
