using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using UnityEngine.UI;


public class FileSave : MonoBehaviour
{
    [SerializeField] Image img;
    [SerializeField] InputField Nameinfo, ageinfo, phoneNumber, fileInfo;

    string folderpath;
    string filepath;

    // Start is called before the first frame update
    void Start()
    {
        folderpath = Application.persistentDataPath + @"SaveFile";

        if (!Directory.Exists(folderpath))
        {
            Directory.CreateDirectory(folderpath);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveInfo()
    {
        FileDataFormat fileData = new FileDataFormat(Name: Nameinfo.text,
            age: int.Parse(ageinfo.text), phoneNumber: int.Parse(phoneNumber.text),
            width: img.sprite.texture.width, height:img.sprite.texture.height); ;

        filepath = @"\FileInfo" + fileInfo.text + "LINA.json";

        var data = JsonConvert.SerializeObject(fileData);

        File.WriteAllText(folderpath + filepath, data);
    }
}
